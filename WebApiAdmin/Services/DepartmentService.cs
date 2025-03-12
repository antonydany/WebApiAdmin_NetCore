using WebApiAdmin.DTOs.Departments;
using WebApiAdmin.Repositories.Interfaces;
using WebApiAdmin.Services.Interfaces;

namespace WebApiAdmin.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync()
        {
            var departments = await _departmentRepository.GetAllDepartmentsAsync();
            var departmentsDtos = departments.Select(department => new DepartmentDto
            {
                DepartmentId = department.DepartmentId,
                DepartmentName = department.DepartmentName,
                DepartmentDescription = department.DepartmentDescription,
                CreatedAt = department.CreatedAt,
                IsActive = department.IsActive
            });
            return departmentsDtos;
        }
    }
}
