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
    [Route("api/Employee")]
    //[Route("[controller]")]

    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            //this.employeeService = employeeService;
            _employeeService = employeeService;
        }


        [HttpGet]
        //[Route("[controller]")]
        //[Route("api/Employee/GetEmployees")]
        [Route("GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }


        [HttpPost]
        //[Route("[controller]")]
        //[Route("api/Employee/AddEmployee")]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return Ok("Added Sucessfully!");
        }


        [HttpPut]
        //[Route("[controller")]
        //[Route("api/Employee/UpdateEmployee")]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return Ok("Updated Successfully!");
        }


        [HttpDelete]
        //[Route("[controller]")]
        //[Route("api/Employee/DeleteEmployee")]
        [Route("DeleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            var existingEmployee = _employeeService.GetEmployee(id);
            if (existingEmployee != null)
            {
                _employeeService.DeleteEmployee(existingEmployee.Id);
                return Ok("Record Deleted!");
            }
            return NotFound($"Employee not found with ID : {existingEmployee.Id}");
        }


        [HttpGet]
        [Route("GetEmployee")]
        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }


















        //[HttpGet("{id}")]
        //public ActionResult<Employee> Get(int id)
        //{
        //    var employee = EmployeeService.Get(id);

        //    if (employee == null)
        //        return NotFound();

        //    return employee;
        //}

        //[HttpPost]
        //public int SaveEmployee([FromBody] EmployeeModel employeeModel)
        //{
        //    return employeeService.SaveEmployee(employeeModel);
        //}

        //[HttpPost]
        //public IActionResult Create(Employee employee)
        //{
        //    EmployeeService.Add(employee);
        //    return CreatedAtAction(nameof(Create), new { id = employee.Id }, employee);
        //}


        //[HttpPut("{id}")]
        //public IActionResult UpdateEmployee(int id, Employee employee)
        //{
        //    if (id != employee.Id)
        //        return BadRequest();

        //    var existingPizza = EmployeeService.Get(id);
        //    if (existingPizza is null)
        //        return NotFound();

        //    EmployeeService.UpdateEmployee(employee);

        //    return NoContent();
        //}


        //[HttpDelete("{id}")]
        //public IActionResult DeleteEmployee(int id)
        //{
        //    var employee = EmployeeService.Get(id);

        //    if (employee is null)
        //        return NotFound();

        //    EmployeeService.DeleteEmployee(id);

        //    return NoContent();
        //}


        //[HttpDelete("{id}")]
        //public ActionResult DeleteEmployee(int id)
        //{
        //    var employee = employeeService.GetEmployees(id);

        //    if (employee is null)
        //        return NotFound();

        //    EmployeeService.DeleteEmployee(id);

        //    return NoContent();
        //}


    }
}




