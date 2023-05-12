using AccountService.Application.Wrappers;

namespace AccountService.Application.UseCases.AccountService.GetAccount;

public class GetAccountResponse : ResponseBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
