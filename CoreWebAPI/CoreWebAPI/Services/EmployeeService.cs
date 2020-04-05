using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPI.Models;

namespace CoreWebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private Dictionary<int, EmployeeModel> employeeData;
        public EmployeeService()
        {
            employeeData = new Dictionary<int, EmployeeModel>();
        }
        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            employeeData.Add(employee.EmpId, employee);

            return employee;
        }
    }
}
