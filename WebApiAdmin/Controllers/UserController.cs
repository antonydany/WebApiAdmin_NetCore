using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApiAdmin.DTOs.Roles;
using WebApiAdmin.DTOs.Users;
using WebApiAdmin.Services.Interfaces;

namespace WebApiAdmin.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsersAsync()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("summary")]
        public async Task<ActionResult<IEnumerable<UserSummaryDto>>> GetAllUsersSummaryAsync()
        {
            var users = await _userService.GetAllUsersSummaryAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetDepartmentByIdAsync(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if ( user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

    }
}
