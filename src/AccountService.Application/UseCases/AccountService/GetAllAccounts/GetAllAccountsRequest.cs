using AccountService.Application.Interfaces;
using MediatR;

namespace AccountService.Application.UseCases.AccountService.GetAccount;

public class GetAllAccountsRequest : IRequest<GetAllAccountsResponse>
{
}
