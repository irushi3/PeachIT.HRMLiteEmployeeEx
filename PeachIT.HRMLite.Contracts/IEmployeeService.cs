using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeachIT.HRMLite.Domain;
using PeachIT.HRMLite.Models;

namespace PeachIT.HRMLite.Contracts
{
    public interface IEmployeeService
    {
        //List<EmployeeModel> GetEmployees();
        //public int SaveEmployee(EmployeeModel employee);
        //public string DeleteEmployee(int id);

        Employee AddEmployee(Employee employee);

        List<Employee> GetEmployee();

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int Id);

        Employee GetEmployee(int? id);


    }
}

