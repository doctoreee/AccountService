using AccountService.Domain.Exceptions;
using AccountService.Domain.RepositoryInterfaces.Sqlite;
using MediatR;

namespace AccountService.Application.UseCases.AccountService.UpdateAccount;

public class UpdateAccountHandler : IRequestHandler<UpdateAccountRequest, UpdateAccountResponse>
{
    private readonly IAccountRepository _accountRepository;

    public UpdateAccountHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<UpdateAccountResponse> Handle(UpdateAccountRequest request, CancellationToken cancellationToken)
    {
        request.Validate();
        var entity =  await _accountRepository.GetByIdAsync(request.Id);
        if (entity == null)
        {
            throw new DomainException(DomainExceptionContent.CannotFountAccount);
        }
        entity.FirstName = request.FirstName;
        entity.LastName = request.LastName;

        _accountRepository.Update(request.Id, entity);

        return new UpdateAccountResponse() { Success = true };
    }
}
