using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeachIT.HRMLite.Contracts;
using PeachIT.HRMLite.Domain;
using PeachIT.HRMLite.DAL;
using AutoMapper;


namespace PeachIT.HRMLite.BL
{
   public class DepartmentService : IDepartmentService
    {
        private readonly IMapper mapper;

        public HRMLiteContext _context;

        public DepartmentService(HRMLiteContext context, IMapper mapper)
        {
            //this.context = context;
            _context = context;
            this.mapper = mapper;
        }

        public Department AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;
        }

        public List<Department> GetDepartment()
        {
            //var employees = context.Employees.ToList();
            //return mapper.Map<List<EmployeeModel>>(employees);
            return _context.Departments.ToList();
        }

        public void UpdateDepartment(Department department)
        {
            _context.Departments.Update(department);
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

        public void DeleteDepartment(int id)
        {
            var department = _context.Departments.FirstOrDefault(x => x.Id == id);
            if (department != null)
            {
                _context.Remove(department);
                _context.SaveChanges();
            }
        }


        public Department GetDepartment(int id)
        {
            return _context.Departments.FirstOrDefault(x => x.Id == id);
        }
    }
}
