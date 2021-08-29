using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeachIT.HRMLite.Contracts;
using System.Collections.Generic;
using PeachIT.HRMLite.Domain;

namespace PeachIT.HRMLite.API.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    [Route("[controller]")]

    public class DepartmentsController : ControllerBase
    {
        private readonly ILogger<DepartmentsController> _logger;
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(ILogger<DepartmentsController> logger, IDepartmentService departmentService)
        {
            _logger = logger;
            //this.employeeService = employeeService;
            _departmentService = departmentService;
        }


        [HttpGet]
        [Route("[controller]")]
        //[Route("api/Employee/GetEmployees")]
        public IEnumerable<Department> GetDepartments()
        {
            return _departmentService.GetDepartment();
        }


        [HttpPost]
        //[Route("[controller]")]
        //[Route("api/Employee/AddEmployee")]
        public IActionResult AddDepartment(Department department)
        {
            _departmentService.AddDepartment(department);
            return Ok();
        }


        [HttpPut]
        //[Route("[controller")]
        //[Route("api/Employee/UpdateEmployee")]
        public IActionResult UpdateDepartment(Department department)
        {
            _departmentService.UpdateDepartment(department);
            return Ok();
        }

        //[HttpPut]
        ////[Route("[controller]")]
        ////[Route("api/Employee/DeleteEmployee")]
        //public IActionResult UpdateEmployee(int id)
        //{
        //    var existingEmployee = _employeeService.GetEmployee(id);
        //    if (existingEmployee != null)
        //    {
        //        _employeeService.UpdateEmployee(existingEmployee.Id);
        //        return Ok();
        //    }
        //    return NotFound($"Employee not found with ID : {existingEmployee.Id}");
        //}


        [HttpDelete]
        //[Route("[controller]")]
        //[Route("api/Employee/DeleteEmployee")]
        public IActionResult DeleteDepartment(int id)
        {
            var existingDepartment = _departmentService.GetDepartment(id);
            if (existingDepartment != null)
            {
                _departmentService.DeleteDepartment(existingDepartment.Id);
                return Ok();
            }
            return NotFound($"Employee not found with ID : {existingDepartment.Id}");
        }


        [HttpGet]
        [Route("GetDepartment")]
        public Department GetDepartment(int id)
        {
            return _departmentService.GetDepartment(id);
        }
    }
}
