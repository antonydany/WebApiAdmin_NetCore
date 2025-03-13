using WebApiAdmin.DTOs.Roles;
using WebApiAdmin.Repositories.Interfaces;
using WebApiAdmin.Services.Interfaces;

namespace WebApiAdmin.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _context;
        public RoleService(IRoleRepository context)
        {
            _context = context;    
        }
        public async Task<IEnumerable<RoleDto>> GetAllRolesAsync()
        {
            var roles = await _context.GetAllRolesAsync();
            var rolesDto = roles.Select(role => new RoleDto
            {
                RoleId = role.RoleId,
                RoleName = role.RoleName,
                RoleDescription = role.RoleDescription,
                DateTime = role.DateTime,
                IsActive = role.IsActive
            });

            return rolesDto;
        }
    }
}
