using AccountService.Application.Wrappers;
using AccountService.Domain.Entities;

namespace AccountService.Application.UseCases.AccountService.GetAccount;

public class GetAllAccountsResponse : ResponseBase
{
    public List<Account> accounts { get; set; }
}
