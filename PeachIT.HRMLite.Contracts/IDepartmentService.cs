using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeachIT.HRMLite.Domain;
using PeachIT.HRMLite.Models;

namespace PeachIT.HRMLite.Contracts
{
    public interface IDepartmentService
    {
        Department AddDepartment(Department department);

        List<Department> GetDepartments();

        void UpdateDepartment(Department department);

        void DeleteDepartment(int Id);

        Department GetDepartment(int Id);
    }
}
