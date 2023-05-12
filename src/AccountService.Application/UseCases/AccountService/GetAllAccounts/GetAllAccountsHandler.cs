using AccountService.Domain.RepositoryInterfaces.Sqlite;
using MediatR;

namespace AccountService.Application.UseCases.AccountService.GetAccount;

public class GetAllAccountsHandler : IRequestHandler<GetAllAccountsRequest, GetAllAccountsResponse>
{
    private readonly IAccountRepository _accountRepository;

    public GetAllAccountsHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<GetAllAccountsResponse> Handle(GetAllAccountsRequest request, CancellationToken cancellationToken)
    {
        var entities = _accountRepository.Get();
        return new GetAllAccountsResponse() { accounts = entities.ToList() };
    }
}
