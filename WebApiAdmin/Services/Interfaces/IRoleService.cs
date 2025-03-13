using WebApiAdmin.DTOs.Roles;

namespace WebApiAdmin.Services.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDto>> GetAllRolesAsync();
    }
}
