namespace WebApiAdmin.Models
{
    public class User
    {
        public int UserId { get; set; }
        public required string Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;

        public User()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        //relationship
        public Department? Department { get; set; }
        public Role? Role { get; set; }
    }
}
