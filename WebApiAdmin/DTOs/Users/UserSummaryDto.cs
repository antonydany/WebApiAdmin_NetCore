namespace WebApiAdmin.DTOs.Users
{
    public class UserSummaryDto
    {
        public int UserId { get; set; }
        public required string Name { get; set; }
        public string? LastName { get; set; }
        public required string DepartmentName { get; set; } 
        public required string RoleName { get; set; }
        public bool IsActive { get; set; }
    }
}
