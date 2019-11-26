using FSL.ApiCustomIdentity.Filters;
using FSL.ApiCustomIdentity.Models;
using FSL.ApiCustomIdentity.Service;
using Microsoft.AspNetCore.Mvc;

namespace FSL.ApiCustomIdentity.Controllers
{
    [Route("api/user")]
    [ApiController]
    [MyAuthorize]
    public sealed class UserController : ControllerBase
    {
        private readonly ILoggedUserService _loggedUserService;

        public UserController(
            ILoggedUserService loggedUserService)
        {
            _loggedUserService = loggedUserService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var user = _loggedUserService.GetLoggedUser<MyLoggedUser>();

            return Ok(user);
        }
    }
}
