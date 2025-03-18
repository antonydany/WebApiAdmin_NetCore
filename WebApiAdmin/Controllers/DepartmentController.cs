using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApiAdmin.DTOs.Departments;
using WebApiAdmin.Services.Interfaces;

namespace WebApiAdmin.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _deparmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _deparmentService = departmentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> GetAllDepartmentAsync()
        {
            var departments = await _deparmentService.GetAllDepartmentsAsync();
            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentDto>> GetDepartmentByIdAsync(int id)
        {
            var department = await _deparmentService.GetDepartmentByIdAsync(id);
            if(department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }
    }
}
