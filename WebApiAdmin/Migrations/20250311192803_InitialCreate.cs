using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "CreatedAt", "DepartmentDescription", "DepartmentName", "IsActive" },
                values: new object[,]
                {
                    { 1, new DateOnly(2025, 3, 11), "Recursos Humanos de la Matriz", "MT_RH", true },
                    { 2, new DateOnly(2025, 3, 11), "Operaciones de la Matriz", "MT_OP", true },
                    { 3, new DateOnly(2025, 3, 11), "Contabilidad y Finanzas de la Matriz", "MT_CF", true },
                    { 4, new DateOnly(2025, 3, 11), "Marketing de la Matriz", "MT_MK", true },
                    { 5, new DateOnly(2025, 3, 11), "Recursos Humanos de la Sucursal 1", "S1_RH", true },
                    { 6, new DateOnly(2025, 3, 11), "Operaciones de la Sucursal 1", "S1_OP", true },
                    { 7, new DateOnly(2025, 3, 11), "Contabilidad y Finanzas de la Sucursal 1", "S1_CF", true },
                    { 8, new DateOnly(2025, 3, 11), "Marketing de la Sucursal 1", "S1_MK", true }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "DateTime", "IsActive", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Rol de Administrador", "Administrator" },
                    { 2, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Rol de Empleado", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "City", "Country", "CreatedAt", "DateOfBirth", "DepartmentId", "Email", "IsActive", "LastName", "Name", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Matriz 1 administrador", "Colima", "México", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 3, 11), 1, "admin@admin.com", true, "Administrador", "Admin", 1, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Sucursal 1 administrador", "Manzanillo", "México", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 6, 22), 5, "empleado1@empleados.com", true, "Empleado de sucursal", "Empleado 1", 2, new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
