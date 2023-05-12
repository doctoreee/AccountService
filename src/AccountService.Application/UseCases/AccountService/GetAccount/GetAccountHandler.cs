using AccountService.Domain.RepositoryInterfaces.Sqlite;
using MediatR;

namespace AccountService.Application.UseCases.AccountService.GetAccount;

public class GetAccountHandler : IRequestHandler<GetAccountRequest, GetAccountResponse>
{
    private readonly IAccountRepository _accountRepository;

    public GetAccountHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<GetAccountResponse> Handle(GetAccountRequest request, CancellationToken cancellationToken)
    {
        request.Validate();
        var entity = await _accountRepository.GetByIdAsync(request.Id);

        return new GetAccountResponse() { Success = true, FirstName = entity.FirstName, LastName = entity.LastName };
    }
}
