using Microsoft.AspNetCore.Mvc;
using server.Dto;
using server.Services;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // POST /api/user/login
        [HttpPost("Login")]
        public IActionResult Login(LoginDto param)
        {
            var result = _userService.Login(param);
            if (result == null)
                return NotFound("帳號或密碼錯誤");

            return Ok(result);
        }
    }
}
