using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using PeachIT.HRMLite.Domain;
using Microsoft.AspNetCore.Http;
using PeachIT.HRMLite.BL;

namespace PeachIT.HRMLite.API.Controllers
{
    [ApiController]
    [Route("api/Department")]
    //[Route("[controller]")]

    public class DepartmentController : ControllerBase
    {
        private readonly ILogger<DepartmentController> _logger;
        private readonly IDepartmentService _departmentService;

        public DepartmentController(ILogger<DepartmentController> logger, IDepartmentService departmentService)
        {
            _logger = logger;
            _departmentService = departmentService;
        }


        [HttpGet]
        //[Route("[controller]")]
        [Route("GetDepartments")]
        public IEnumerable<Department> GetDepartments()
        {
            return _departmentService.GetDepartments();
        }


        [HttpPost]
        [Route("AddDepartment")]
        public IActionResult AddDepartment(Department department)
        {
            _departmentService.AddDepartment(department);
            return Ok("Added Sucessfully!");
        }


        [HttpPut]
        [Route("UpdateDepartment")]
        public IActionResult UpdateDepartment(Department department)
        {
            _departmentService.UpdateDepartment(department);
            return Ok("Updated Successfully!");
        }


        [HttpDelete]
        [Route("DeleteDepartment")]
        public IActionResult DeleteDepartment(int id)
        {
            var existingDepartment = _departmentService.GetDepartment(id);
            if (existingDepartment != null)
            {
                _departmentService.DeleteDepartment(existingDepartment.Id);
                return Ok("Record Deleted!");
            }
            return NotFound($"Department not found with ID : {existingDepartment.Id}");
        }


        [HttpGet]
        [Route("GetDepartment")]
        public Department GetDepartment(int id)
        {
            return _departmentService.GetDepartment(id);
        }
    }
}
