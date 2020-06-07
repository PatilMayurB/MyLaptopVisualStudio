using CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Services
{
    public interface IEmployeeService
    {
        EmployeeModel AddEmployee(EmployeeModel employee);
        List<EmployeeModel> GetAllEmployee();
        EmployeeModel GetEmployee(int id);
        EmployeeModel GetLogin(EmployeeModel employee);
        int DeleteEmployee(int id);
        bool UpdateEmployee(EmployeeModel employee);
    }
}
