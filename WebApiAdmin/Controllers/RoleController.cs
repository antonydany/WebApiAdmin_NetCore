using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAdmin.DTOs.Roles;
using WebApiAdmin.Services.Interfaces;

namespace WebApiAdmin.Controllers
{
    [Route("api/role")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleDto>>> GetAllRolesAsync()
        {
            var roles = await _roleService.GetAllRolesAsync();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoleDto>> GetDepartmentByIdAsync(int id)
        {
            var role = await _roleService.GetDepartmentByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            return Ok(role);
        }
    }
}
