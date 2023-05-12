using AccountService.Application.Wrappers;
using AccountService.Domain.Entities;

namespace AccountService.Application.UseCases.AccountService.CreateAccount;

public class CreateAccountResponse : ResponseBase
{
    public Account account { get; set; }
}
