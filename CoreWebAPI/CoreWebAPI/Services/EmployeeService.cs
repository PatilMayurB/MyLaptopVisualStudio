using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPI.Models;

namespace CoreWebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        //private Dictionary<int, EmployeeModel> employeeData;
        private List< EmployeeModel> employeeData;
        public EmployeeService()
        {
            employeeData = new List<EmployeeModel>();
        }
        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            employeeData.Add(employee);

            return employee;
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            return employeeData;
        }

        //NOT IMPLEMENTED AS UNNECESSARY
        public EmployeeModel GetEmployee(int i)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetLogin(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
