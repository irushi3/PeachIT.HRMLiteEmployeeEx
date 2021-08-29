using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeachIT.HRMLite.Contracts;
using System.Collections.Generic;
using PeachIT.HRMLite.Domain;


namespace PeachIT.HRMLite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Route("[controller]")]

    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            //this.employeeService = employeeService;
            _employeeService = employeeService;
        }


        [HttpGet]
        //[Route("[controller]")]
        [Route("GetEmployee/{id?}")]
        public IEnumerable<Employee> GetEmployee(int? id)
        {
            return (IEnumerable<Employee>)_employeeService.GetEmployee(id);
        }


        [HttpPost]
        //[Route("[controller]")]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return Ok();
        }


        [HttpPut]
        //[Route("[controller")]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
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
        [Route("DeleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            var existingEmployee = _employeeService.GetEmployee(id);
            if (existingEmployee != null)
            {
                _employeeService.DeleteEmployee(existingEmployee.Id);
                return Ok();
            }
            return NotFound($"Employee not found with ID : {existingEmployee.Id}");
        }


        //[HttpGet("{id:int}")]
        //[Route("GetEmployee")]
        //[Route("GetEmployee/{id?}")]
        //public Employee GetEmployee(int id)
        //{
        //    return _employeeService.GetEmployee(id);
            
        //}


















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




