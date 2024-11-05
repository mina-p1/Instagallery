using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Instagallery.Models;

namespace Instagallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // Registration endpoint
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userService.RegisterUserAsync(userModel);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok(new { Message = "Registration successful." });
        }

        // Login endpoint
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userService.AuthenticateUserAsync(loginModel.Email, loginModel.Password);
            if (user == null)
            {
                return Unauthorized(new { Message = "Invalid credentials." });
            }

            // Generate a token for the user
            var token = _userService.GenerateJwtToken(user);

            return Ok(new { Token = token });
        }

        // Logout endpoint
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Add logout logic if necessary, such as token invalidation
            return Ok(new { Message = "Logout successful." });
        }
    }
}
