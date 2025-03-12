namespace WebApiAdmin.DTOs.Roles
{
    public class RolesDto
    {
        public int RoleId { get; set; }
        public required string RoleName { get; set; }
        public string? RoleDescription { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
