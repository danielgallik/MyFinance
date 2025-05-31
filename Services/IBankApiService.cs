using System.Collections.Generic;
using System.Threading.Tasks;
using MyFinance.Models;

namespace MyFinance.Services
{
    public interface IBankApiService
    {
        Task<List<Transaction>> GetTransactionsAsync();
    }
}