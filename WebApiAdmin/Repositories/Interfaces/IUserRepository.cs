using WebApiAdmin.Models;

namespace WebApiAdmin.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<IEnumerable<User>> GetAllUsersSummaryAsync();
        Task<User> GetUserByIdAsync(int id);
    }
}
