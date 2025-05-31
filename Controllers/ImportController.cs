using Microsoft.AspNetCore.Mvc;
using MyFinance.Data;
using MyFinance.Models;
using MyFinance.Services;

namespace MyFinance.Controllers
{
    public class ImportController : Controller
    {
        private readonly FinanceDbContext _db;
        private readonly IBankApiService _bankApiService;

        public ImportController(FinanceDbContext db, IBankApiService bankApiService)
        {
            _db = db;
            _bankApiService = bankApiService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ImportTransactions()
        {
            // Ensure basic categories exist
            if (!_db.Categories.Any())
            {
                var defaultCategories = new List<Category>
                {
                    new Category { Name = "Salary" },
                    new Category { Name = "Groceries" },
                    new Category { Name = "Shopping" },
                    new Category { Name = "Coffee" },
                    new Category { Name = "Books" },
                    new Category { Name = "Electronics" },
                    new Category { Name = "Pharmacy" },
                    new Category { Name = "Gym" },
                    new Category { Name = "Cinema" },
                    new Category { Name = "Restaurant" },
                    new Category { Name = "Refund" },
                    new Category { Name = "Clothes" },
                    new Category { Name = "Bakery" },
                    new Category { Name = "Taxi" },
                    new Category { Name = "Utilities" },
                    new Category { Name = "Other" }
                };
                _db.Categories.AddRange(defaultCategories);
                await _db.SaveChangesAsync();
            }

            // Get transactions from bank API
            var transactions = await _bankApiService.GetTransactionsAsync();

            // Save new transactions to database
            foreach (var transaction in transactions)
            {
                // Assign category based on description or use "Other"
                var categoryName = transaction.Description ?? "Other";
                var category = _db.Categories.FirstOrDefault(c => c.Name == categoryName) 
                               ?? _db.Categories.First(c => c.Name == "Other");
                transaction.CategoryId = category.Id;

                // Skip duplicates by unique TransactionId
                if (!_db.Transactions.Any(t => t.TransactionId == transaction.TransactionId))
                {
                    _db.Transactions.Add(transaction);
                }
            }
            await _db.SaveChangesAsync();

            TempData["ImportResult"] = "Import completed!";
            return RedirectToAction("Index");
        }
    }
}