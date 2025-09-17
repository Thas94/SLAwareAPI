using Microsoft.AspNetCore.Mvc;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;

namespace SLAwareApi.Controllers.SLAware
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //[HttpGet]
        //public async Task<UserModel> Login(string firstname) => await _userService.Login(firstname);
    }
}
