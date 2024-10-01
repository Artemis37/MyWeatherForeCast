using Domain.Model.Result;

namespace Application.Interface
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAllAccountsAsync();
    }
}
