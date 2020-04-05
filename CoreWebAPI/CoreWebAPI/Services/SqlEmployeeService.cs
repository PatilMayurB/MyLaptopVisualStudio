using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPI.Models;

namespace CoreWebAPI.Services
{
    public class SqlEmployeeService : IEmployeeService
    {
        private AppDbContext context;

        public SqlEmployeeService(AppDbContext context)
        {
            this.context = context;
        }
        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();

            return employee;
        }
    }
}
