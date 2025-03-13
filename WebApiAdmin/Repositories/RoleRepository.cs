using Microsoft.EntityFrameworkCore;
using WebApiAdmin.Data;
using WebApiAdmin.Models;
using WebApiAdmin.Repositories.Interfaces;

namespace WebApiAdmin.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly WebApiAdminContext _context;
        public RoleRepository(WebApiAdminContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }
    }
}
