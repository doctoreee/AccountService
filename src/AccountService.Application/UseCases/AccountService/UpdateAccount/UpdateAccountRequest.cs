using AccountService.Application.Interfaces;
using AccountService.Domain.Exceptions;
using MediatR;

namespace AccountService.Application.UseCases.AccountService.UpdateAccount;

public class UpdateAccountRequest : IRequest<UpdateAccountResponse>, IRequestValidator
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Validate()
    {
        if (Id == default)
        {
            throw new DomainException(DomainExceptionContent.IdCannotBeEmpty);
        }

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
