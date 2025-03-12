using Microsoft.EntityFrameworkCore;
using WebApiAdmin.Data;
using WebApiAdmin.Models;
using WebApiAdmin.Repositories.Interfaces;

namespace WebApiAdmin.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly WebApiAdminContext _context;

        public DepartmentRepository(WebApiAdminContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _context.Departments.ToListAsync();
        }
    }
}
