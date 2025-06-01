using System;

namespace MyFinance.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string TransactionId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime ValueDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        // Debtor (sender)
        public int? DebtorId { get; set; }
        public Party Debtor { get; set; }

        // Creditor (recipient)
        public int? CreditorId { get; set; }
        public Party Creditor { get; set; }

        public string? RemittanceInformationUnstructured { get; set; }
        public string? RemittanceInformationUnstructuredArray { get; set; }
        public string InternalTransactionId { get; set; }

        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}