using Microsoft.EntityFrameworkCore.Query;
using WebApiAdmin.DTOs.Users;
using WebApiAdmin.Repositories.Interfaces;
using WebApiAdmin.Services.Interfaces;

namespace WebApiAdmin.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();

            var usersDtos = users.Select(user => new UserDto {
            UserId = user.UserId,
            Name = user.Name,
            LastName = user.LastName,
            Email = user.Email,
            DateOfBirth = user.DateOfBirth,
            DepartmentName = user.Department.DepartmentName,
            RoleName = user.Role.RoleName,
            Address = user.Address,
            Country = user.Country,
            City = user.City,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt,
            IsActive = user.IsActive
            });

            return usersDtos;
           
        }

        public async Task<IEnumerable<UserSummaryDto>> GetAllUsersSummaryAsync()
        {
            var users = await _userRepository.GetAllUsersSummaryAsync();

            var usersSummaryDtos = users.Select(user => new UserSummaryDto
            {
                UserId = user.UserId,
                Name = user.Name,
                LastName = user.LastName,
                DepartmentName = user.Department.DepartmentName,
                RoleName = user.Role.RoleName,
                IsActive = user.IsActive
            });

            return usersSummaryDtos;

        }
    }
}
