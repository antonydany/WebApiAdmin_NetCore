namespace WebApiAdmin.DTOs.Departments
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; }
        public required string DepartmentDescription { get; set; }

        public DateOnly CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
