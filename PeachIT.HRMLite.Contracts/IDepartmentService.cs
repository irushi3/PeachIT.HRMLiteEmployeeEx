using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeachIT.HRMLite.Domain;


namespace PeachIT.HRMLite.Contracts
{
    public interface IDepartmentService 
    {
        Department AddDepartment(Department department);

        List<Department> GetDepartment();

        void UpdateDepartment(Department department);

        void DeleteDepartment(int Id);

        Department GetDepartment(int Id);
    }
}
