using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.DAL;
using PeachIT.HRMLite.Domain;
using PeachIT.HRMLite.Models;


namespace PeachIT.HRMLite.BL
{
    public class EmployeeService : IEmployeeService
    {
        //private readonly HRMLiteContext context;
        private readonly IMapper mapper;

        public HRMLiteContext _context;

        public EmployeeService(HRMLiteContext context, IMapper mapper)
        {
            //this.context = context;
            _context = context;
            this.mapper = mapper;
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public List<Employee> GetEmployee()
        {
            //var employees = context.Employees.ToList();
            //return mapper.Map<List<EmployeeModel>>(employees);
            return _context.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        //public void UpdateEmployee(int id)
        //{
        //    var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
        //    if (employee != null)
        //    {
        //        _context.Update(employee);
        //        _context.SaveChanges();
        //    }
        //}

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _context.Remove(employee);
                _context.SaveChanges();
            }
        }


        public Employee GetEmployee(int? id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        //public List<Employee> GetEmployee(int? id)
        //{
        //    throw new NotImplementedException();
        //}





        ////need to check this line
        //public static EmployeeModel Get(int id) => Employees.FirstorDefault(p => p.Id == id);

        //public int SaveEmployee(EmployeeModel employeeModel)
        //{
        //    if (employeeModel == null)
        //        throw new ArgumentNullException();

        //    Employee employee = employeeModel.Id > 0 ?
        //        context.Employees.Single<Employee>(p => p.Id == employeeModel.Id) :
        //        new Employee();

        //    employee = mapper.Map<Employee>(employeeModel);
        //    context.Add(employee);
        //    context.SaveChanges();

        //    return employee.Id;
        //}





        //if (employeeModel == null)
        //    throw new ArgumentNullException();

        //id = employeeModel.Id;

        //if (employee == null)
        //{
        //    return NotFound();
        //}

        //    Employee employee = context.Employees.Find(id);

        //    context.Employees.Remove(employee);
        //    context.SaveChanges();

        //    var employees = context.Employees.ToList();
        //    return mapper.Map<List<EmployeeModel>>(employees);
        //}

        //private int Ok(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
