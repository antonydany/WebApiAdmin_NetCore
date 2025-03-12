namespace WebApiAdmin.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; }
        public required string DepartmentDescription { get; set; }

        public DateOnly CreatedAt { get; set; }
        public bool IsActive { get; set; } = true;

        public Department()
        {
            CreatedAt = DateOnly.FromDateTime(DateTime.Now);
        }

        //relationship
        public ICollection<User>? Users { get; set; }

    }
}
