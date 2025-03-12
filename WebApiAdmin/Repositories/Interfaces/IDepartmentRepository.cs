using WebApiAdmin.Models;

namespace WebApiAdmin.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
    }
}
