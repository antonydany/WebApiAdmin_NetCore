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

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            var deparment = await _context.Departments.FindAsync(id);
            return deparment;
        }
    }
}
