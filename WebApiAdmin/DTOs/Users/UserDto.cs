namespace WebApiAdmin.DTOs.Users
{
    public class UserDto
    {
        public int UserId { get; set; }
        public required string Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public required string DepartmentName { get; set; }
        public required string RoleName { get; set; } 
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
