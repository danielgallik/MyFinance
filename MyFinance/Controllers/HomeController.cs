using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinance.Models;
using MyFinance.Data;

namespace MyFinance.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FinanceDbContext _db;

    public HomeController(ILogger<HomeController> logger, FinanceDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        var transactions = _db.Transactions
            .Include(t => t.Category)
            .ToList();

        // Example: Group by category for expenses and incomes
        var incomeCategories = new[] { "Salary", "Other Income" }; // adjust as needed
        var expenseCategories = transactions
            .Where(t => t.Amount < 0)
            .Select(t => t.Category?.Name ?? "Other")
            .Distinct()
            .ToList();

        var nodeLabels = new List<string>();
        var nodeColors = new List<string>();
        var linkSource = new List<int>();
        var linkTarget = new List<int>();
        var linkValue = new List<decimal>();

        // Add income nodes
        foreach (var income in transactions.Where(t => t.Amount > 0))
        {
            if (!nodeLabels.Contains(income.Description))
            {
                nodeLabels.Add(income.Description);
                nodeColors.Add("blue");
            }
        }

        // Add central node
        nodeLabels.Add("Total Income");
        nodeColors.Add("green");
        int totalIncomeIdx = nodeLabels.Count - 1;

        // Add expense nodes
        foreach (var expense in expenseCategories)
        {
            nodeLabels.Add(expense);
            nodeColors.Add("red");
        }

        // Income → Total Income
        foreach (var income in transactions.Where(t => t.Amount > 0))
        {
            int sourceIdx = nodeLabels.IndexOf(income.Description);
            linkSource.Add(sourceIdx);
            linkTarget.Add(totalIncomeIdx);
            linkValue.Add(income.Amount);
        }

        // Total Income → Expenses
        foreach (var expense in transactions.Where(t => t.Amount < 0))
        {
            int targetIdx = nodeLabels.IndexOf(expense.Category?.Name ?? "Other");
            linkSource.Add(totalIncomeIdx);
            linkTarget.Add(targetIdx);
            linkValue.Add(Math.Abs(expense.Amount));
        }

        var sankeyData = new SankeyDataModel
        {
            NodeLabels = nodeLabels.ToArray(),
            NodeColors = nodeColors.ToArray(),
            LinkSource = linkSource.ToArray(),
            LinkTarget = linkTarget.ToArray(),
            LinkValue = linkValue.Select(v => (int)v).ToArray()
        };

        return View(sankeyData);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
