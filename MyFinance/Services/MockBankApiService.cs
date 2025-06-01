using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyFinance.Models;

namespace MyFinance.Services
{
    public class MockBankApiService : IBankApiService
    {
        public Task<List<Transaction>> GetTransactionsAsync()
        {
            var transactions = new List<Transaction>
            {
                new Transaction
                {
                    TransactionId = "TXN000001",
                    BookingDate = DateTime.Today.AddDays(-14),
                    ValueDate = DateTime.Today.AddDays(-14),
                    Amount = 1000.00m,
                    Currency = "EUR",
                    Debtor = new Party { Name = "Person A", Iban = "SK0000000000000000000001" },
                    Creditor = null,
                    RemittanceInformationUnstructured = "Salary Payment",
                    RemittanceInformationUnstructuredArray = "REF:1001",
                    InternalTransactionId = "internal-0001",
                    Description = "Salary",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000002",
                    BookingDate = DateTime.Today.AddDays(-13),
                    ValueDate = DateTime.Today.AddDays(-13),
                    Amount = -25.50m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Supermarket", Iban = "SK0000000000000000000002" },
                    RemittanceInformationUnstructured = "Grocery Purchase",
                    RemittanceInformationUnstructuredArray = null,
                    InternalTransactionId = "internal-0002",
                    Description = "Groceries",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000003",
                    BookingDate = DateTime.Today.AddDays(-12),
                    ValueDate = DateTime.Today.AddDays(-12),
                    Amount = -50.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Online Store", Iban = "SK0000000000000000000003" },
                    RemittanceInformationUnstructured = "Online Shopping",
                    RemittanceInformationUnstructuredArray = "REF:1003",
                    InternalTransactionId = "internal-0003",
                    Description = "Shopping",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000004",
                    BookingDate = DateTime.Today.AddDays(-11),
                    ValueDate = DateTime.Today.AddDays(-11),
                    Amount = -15.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Coffee Bar", Iban = "SK0000000000000000000004" },
                    RemittanceInformationUnstructured = "Coffee with friends",
                    RemittanceInformationUnstructuredArray = null,
                    InternalTransactionId = "internal-0004",
                    Description = "Coffee",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000005",
                    BookingDate = DateTime.Today.AddDays(-10),
                    ValueDate = DateTime.Today.AddDays(-10),
                    Amount = -60.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Bookstore", Iban = "SK0000000000000000000005" },
                    RemittanceInformationUnstructured = "Book Purchase",
                    RemittanceInformationUnstructuredArray = "REF:1005",
                    InternalTransactionId = "internal-0005",
                    Description = "Books",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000006",
                    BookingDate = DateTime.Today.AddDays(-9),
                    ValueDate = DateTime.Today.AddDays(-9),
                    Amount = -80.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Electronics Shop", Iban = "SK0000000000000000000006" },
                    RemittanceInformationUnstructured = "Electronics",
                    RemittanceInformationUnstructuredArray = null,
                    InternalTransactionId = "internal-0006",
                    Description = "Electronics",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000007",
                    BookingDate = DateTime.Today.AddDays(-8),
                    ValueDate = DateTime.Today.AddDays(-8),
                    Amount = -30.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Pharmacy", Iban = "SK0000000000000000000007" },
                    RemittanceInformationUnstructured = "Medicine",
                    RemittanceInformationUnstructuredArray = "REF:1007",
                    InternalTransactionId = "internal-0007",
                    Description = "Pharmacy",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000008",
                    BookingDate = DateTime.Today.AddDays(-7),
                    ValueDate = DateTime.Today.AddDays(-7),
                    Amount = -120.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Gym", Iban = "SK0000000000000000000008" },
                    RemittanceInformationUnstructured = "Gym Membership",
                    RemittanceInformationUnstructuredArray = null,
                    InternalTransactionId = "internal-0008",
                    Description = "Gym",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000009",
                    BookingDate = DateTime.Today.AddDays(-6),
                    ValueDate = DateTime.Today.AddDays(-6),
                    Amount = -10.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Cinema", Iban = "SK0000000000000000000009" },
                    RemittanceInformationUnstructured = "Movie Ticket",
                    RemittanceInformationUnstructuredArray = "REF:1009",
                    InternalTransactionId = "internal-0009",
                    Description = "Cinema",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000010",
                    BookingDate = DateTime.Today.AddDays(-5),
                    ValueDate = DateTime.Today.AddDays(-5),
                    Amount = -45.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Restaurant", Iban = "SK0000000000000000000010" },
                    RemittanceInformationUnstructured = "Dinner",
                    RemittanceInformationUnstructuredArray = null,
                    InternalTransactionId = "internal-0010",
                    Description = "Restaurant",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000011",
                    BookingDate = DateTime.Today.AddDays(-4),
                    ValueDate = DateTime.Today.AddDays(-4),
                    Amount = 200.00m,
                    Currency = "EUR",
                    Debtor = new Party { Name = "Person B", Iban = "SK0000000000000000000011" },
                    Creditor = null,
                    RemittanceInformationUnstructured = "Refund",
                    RemittanceInformationUnstructuredArray = "REF:1011",
                    InternalTransactionId = "internal-0011",
                    Description = "Refund",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000012",
                    BookingDate = DateTime.Today.AddDays(-3),
                    ValueDate = DateTime.Today.AddDays(-3),
                    Amount = -70.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Clothing Store", Iban = "SK0000000000000000000012" },
                    RemittanceInformationUnstructured = "Clothes",
                    RemittanceInformationUnstructuredArray = null,
                    InternalTransactionId = "internal-0012",
                    Description = "Clothes",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000013",
                    BookingDate = DateTime.Today.AddDays(-2),
                    ValueDate = DateTime.Today.AddDays(-2),
                    Amount = -5.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Bakery", Iban = "SK0000000000000000000013" },
                    RemittanceInformationUnstructured = "Bread",
                    RemittanceInformationUnstructuredArray = "REF:1013",
                    InternalTransactionId = "internal-0013",
                    Description = "Bakery",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000014",
                    BookingDate = DateTime.Today.AddDays(-1),
                    ValueDate = DateTime.Today.AddDays(-1),
                    Amount = -35.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Taxi Service", Iban = "SK0000000000000000000014" },
                    RemittanceInformationUnstructured = "Taxi Ride",
                    RemittanceInformationUnstructuredArray = null,
                    InternalTransactionId = "internal-0014",
                    Description = "Taxi",
                    CategoryId = 0
                },
                new Transaction
                {
                    TransactionId = "TXN000015",
                    BookingDate = DateTime.Today,
                    ValueDate = DateTime.Today,
                    Amount = -60.00m,
                    Currency = "EUR",
                    Debtor = null,
                    Creditor = new Party { Name = "Utility Company", Iban = "SK0000000000000000000015" },
                    RemittanceInformationUnstructured = "Electricity Bill",
                    RemittanceInformationUnstructuredArray = "REF:1015",
                    InternalTransactionId = "internal-0015",
                    Description = "Utilities",
                    CategoryId = 0
                }
            };
            return Task.FromResult(transactions);
        }
    }
}