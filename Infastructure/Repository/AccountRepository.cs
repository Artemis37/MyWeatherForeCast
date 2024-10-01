using Application.Interface;
using Domain.Model.Result;
using Infastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MyWeatherForeCastContext _context;

        public AccountRepository(MyWeatherForeCastContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await _context.Accounts.ToListAsync();
        }
    }
}
