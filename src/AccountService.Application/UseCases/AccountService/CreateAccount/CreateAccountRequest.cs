using AccountService.Application.Interfaces;
using AccountService.Domain.Exceptions;
using MediatR;

namespace AccountService.Application.UseCases.AccountService.CreateAccount;

public class CreateAccountRequest : IRequest<CreateAccountResponse>, IRequestValidator
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Validate()
    {
        if (FirstName == string.Empty)
        {
            throw new DomainException(DomainExceptionContent.FirstNameCannotBeEmpty);
        }

        if (LastName == string.Empty)
        {
            throw new DomainException(DomainExceptionContent.LastNameCannotBeEmpty);
        }
    }
}
