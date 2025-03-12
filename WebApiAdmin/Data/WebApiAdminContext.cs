using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebApiAdmin.Models;

namespace WebApiAdmin.Data
{
    public class WebApiAdminContext : DbContext
    {
        public WebApiAdminContext(DbContextOptions<WebApiAdminContext> options) : base(options) { } 

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(u => u.Department)
                .WithMany(d => d.Users)
                .HasForeignKey(u => u.DepartmentId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);


            //Seed Data
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "MT_RH", DepartmentDescription = "Recursos Humanos de la Matriz", CreatedAt = DateOnly.FromDateTime(new DateTime(2025, 3, 11, 0, 0, 0)) },
                new Department { DepartmentId = 2, DepartmentName = "MT_OP", DepartmentDescription = "Operaciones de la Matriz", CreatedAt = DateOnly.FromDateTime(new DateTime(2025, 3, 11, 0, 0, 0)) },
                new Department { DepartmentId = 3, DepartmentName = "MT_CF", DepartmentDescription = "Contabilidad y Finanzas de la Matriz", CreatedAt = DateOnly.FromDateTime(new DateTime(2025, 3, 11, 0, 0, 0)) },
                new Department { DepartmentId = 4, DepartmentName = "MT_MK", DepartmentDescription = "Marketing de la Matriz", CreatedAt = DateOnly.FromDateTime(new DateTime(2025, 3, 11, 0, 0, 0)) },
                new Department { DepartmentId = 5, DepartmentName = "S1_RH", DepartmentDescription = "Recursos Humanos de la Sucursal 1", CreatedAt = DateOnly.FromDateTime(new DateTime(2025, 3, 11, 0, 0, 0)) },
                new Department { DepartmentId = 6, DepartmentName = "S1_OP", DepartmentDescription = "Operaciones de la Sucursal 1", CreatedAt = DateOnly.FromDateTime(new DateTime(2025, 3, 11, 0, 0, 0)) },
                new Department { DepartmentId = 7, DepartmentName = "S1_CF", DepartmentDescription = "Contabilidad y Finanzas de la Sucursal 1", CreatedAt = DateOnly.FromDateTime(new DateTime(2025, 3, 11, 0, 0, 0)) },
                new Department { DepartmentId = 8, DepartmentName = "S1_MK", DepartmentDescription = "Marketing de la Sucursal 1", CreatedAt = DateOnly.FromDateTime(new DateTime(2025, 3, 11, 0, 0, 0)) }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Administrator", RoleDescription = "Rol de Administrador", DateTime = new DateTime(2025, 3, 11, 0, 0, 0) },
                new Role { RoleId = 2, RoleName = "Employee", RoleDescription = "Rol de Empleado", DateTime = new DateTime(2025, 3, 11, 0, 0, 0) }
                );
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Admin", LastName = "Administrador", DepartmentId = 1, RoleId = 1, Email = "admin@admin.com", City = "Colima", Country = "México", Address="Matriz 1 administrador", DateOfBirth = DateOnly.FromDateTime(new DateTime(2000, 3, 11, 0, 0, 0)), CreatedAt = new DateTime(2025, 3, 11, 0, 0, 0), UpdatedAt = new DateTime(2025, 3, 11, 0, 0, 0) },
                new User { UserId = 2, Name = "Empleado 1", LastName = "Empleado de sucursal", DepartmentId = 5, RoleId = 2, Email = "empleado1@empleados.com", City = "Manzanillo", Country = "México", Address = "Sucursal 1 administrador", DateOfBirth = DateOnly.FromDateTime(new DateTime(2000, 6, 22, 0, 0, 0)), CreatedAt = new DateTime(2025, 3, 11, 0, 0, 0), UpdatedAt = new DateTime(2025, 3, 11, 0, 0, 0) }
                );


        }
    }
}
