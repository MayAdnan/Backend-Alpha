using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Presentation.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet ("Get Users")]
        [SwaggerOperation(Summary = "Get all users")]
        [SwaggerResponse(200, "Success")]
        [SwaggerResponse(500, "Internal Server Error")]
        
        public async Task<IActionResult> GetUsers()
        {
                var users = await _userService.GetUsersAsync();
                 return Ok(users);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get user by id")]
        [SwaggerResponse(200, "User found and returned")]
        [SwaggerResponse(404, "User not found")]

        public async Task<IActionResult> GetUserById(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}

  
