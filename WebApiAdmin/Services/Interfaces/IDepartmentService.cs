using WebApiAdmin.DTOs.Departments;

namespace WebApiAdmin.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
    }
}
