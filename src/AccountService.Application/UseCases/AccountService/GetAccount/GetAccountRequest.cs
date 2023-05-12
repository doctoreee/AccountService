using AccountService.Application.Interfaces;
using AccountService.Domain.Exceptions;
using MediatR;

namespace AccountService.Application.UseCases.AccountService.GetAccount;

public class GetAccountRequest : IRequest<GetAccountResponse>, IRequestValidator
{
    public int Id { get; set; }

    public void Validate()
    {
        if (Id == default)
        {
            throw new DomainException(DomainExceptionContent.IdCannotBeEmpty);
        }
    }
}
