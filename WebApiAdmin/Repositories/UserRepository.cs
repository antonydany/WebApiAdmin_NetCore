using Microsoft.EntityFrameworkCore;
using WebApiAdmin.Data;
using WebApiAdmin.Models;
using WebApiAdmin.Repositories.Interfaces;

namespace WebApiAdmin.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WebApiAdminContext _context;

        public UserRepository(WebApiAdminContext appContext)
        {
            _context = appContext;   
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users
                .Include(d => d.Department)
                .Include(r => r.Role)
                .ToListAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsersSummaryAsync()
        {
            return await _context.Users
                .Include(d => d.Department)
                .Include(r => r.Role)
                .ToListAsync();
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _context.Users
                .Include(d => d.Department)
                .Include(r => r.Role)
                .FirstOrDefaultAsync(u => u.UserId == id);
            return user;
        }
    }
}
