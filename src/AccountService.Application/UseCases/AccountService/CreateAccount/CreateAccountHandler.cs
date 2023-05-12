using AccountService.Domain.Entities;
using AccountService.Domain.RepositoryInterfaces.Sqlite;
using MediatR;

namespace AccountService.Application.UseCases.AccountService.CreateAccount;

public class CreateAccountHandler : IRequestHandler<CreateAccountRequest, CreateAccountResponse>
{
    private readonly IAccountRepository _accountRepository;

    public CreateAccountHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<CreateAccountResponse> Handle(CreateAccountRequest request, CancellationToken cancellationToken)
    {
        request.Validate();
        var account = new Account(request.FirstName, request.LastName);
        account = await _accountRepository.AddAsync(account);

        return new CreateAccountResponse() { Success = true, account = account };
    }
}
