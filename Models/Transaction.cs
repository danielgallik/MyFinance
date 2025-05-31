using System;

namespace MyFinance.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}