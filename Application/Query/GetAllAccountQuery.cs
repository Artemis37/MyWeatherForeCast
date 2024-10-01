using Application.Interface;
using Domain.Model.Result;
using MediatR;

namespace Application.Query
{
    public class GetAllAccountQuery : IRequest<IEnumerable<Account>>
    {
    }

    public class GetAllAccountQueryHandler : IRequestHandler<GetAllAccountQuery, IEnumerable<Account>>
    {
        private readonly IAccountRepository _accountRepository;

        public GetAllAccountQueryHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<IEnumerable<Account>> Handle(GetAllAccountQuery request, CancellationToken cancellationToken)
        {
            var accounts = await _accountRepository.GetAllAccountsAsync();
            return accounts;
        }
    }
}
