using WebApiAdmin.DTOs.Users;

namespace WebApiAdmin.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();

        Task<IEnumerable<UserSummaryDto>> GetAllUsersSummaryAsync();
        Task<UserDto> GetUserByIdAsync(int id);
    }
}
