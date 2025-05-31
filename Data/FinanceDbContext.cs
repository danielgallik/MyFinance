using Microsoft.EntityFrameworkCore;
using MyFinance.Models;

namespace MyFinance.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Party> Parties { get; set; }
    }
}