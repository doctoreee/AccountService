using Microsoft.AspNetCore.Mvc;

namespace AccountService.API.Models.Request
{
    public class AccountBaseModel
    {
        [FromQuery]
        public int Id { get; set; }
    }
}
