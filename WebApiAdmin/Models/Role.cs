using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApiAdmin.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public required string RoleName { get; set; }
        public string? RoleDescription { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsActive { get; set; } = true;

        public Role()
        {
            DateTime = DateTime.Now;
        }
        //relationship
        public ICollection<User>? Users { get; set; }
    }
}
