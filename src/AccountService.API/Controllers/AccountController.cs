using AccountService.API.Models.Request;
using AccountService.API.Wrappers;
using AccountService.Application.UseCases.AccountService.CreateAccount;
using AccountService.Application.UseCases.AccountService.GetAccount;
using AccountService.Application.UseCases.AccountService.UpdateAccount;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AccountService.API.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<AccountController> _logger;

    public AccountController(IMediator mediator, ILogger<AccountController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpPost]
    [Route("api/account")]
    public async Task<IActionResult> Create(CreateAccountModel request)
    {
        var applicationRequest = new CreateAccountRequest() { FirstName = request.FirstName, LastName = request.LastName };
        var response = await _mediator.Send(applicationRequest);

        return Ok(response.ToApiResponse());
    }

    [HttpGet]
    [Route("api/account")]
    public async Task<IActionResult> Get([FromQuery]AccountBaseModel request)
    {
        var applicationRequest = new GetAccountRequest() { Id = request.Id };
        var response = await _mediator.Send(applicationRequest);

        return Ok(response.ToApiResponse());
    }

    [HttpPut]
    [Route("api/account")]
    public async Task<IActionResult> Update([FromRoute]AccountBaseModel idParam, UpdateAccountModel request)
    {
        var applicationRequest = new UpdateAccountRequest() { Id = idParam.Id, FirstName = request.FirstName, LastName = request.LastName };
        var response = await _mediator.Send(applicationRequest);

        return Ok(response.ToApiResponse());
    }

    [HttpGet]
    [Route("api/accounts/all")]
    public async Task<IActionResult> All()
    {
        var applicationRequest = new GetAllAccountsRequest();
        var response = await _mediator.Send(applicationRequest);

        return Ok(response.ToApiResponse());
    }
}