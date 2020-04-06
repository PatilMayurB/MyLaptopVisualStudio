﻿using System;
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
        public List<EmployeeModel> GetAllEmployee()
        {
            return context.Employees.ToList();
        }

        public EmployeeModel GetEmployee(int id)
        {
            var employee = context.Employees.Where(a => a.EmpId == id).SingleOrDefault();
            return employee;
        }

        public EmployeeModel GetLogin(EmployeeModel employee)
        {
            try
            {
                var employeeFound = context.Employees.Where(a => a.UserName == employee.UserName && a.Password == employee.Password).SingleOrDefault();
                //if (employeeFound.UserName == employee.UserName && employeeFound.Password == employee.Password)
                if (employeeFound != null)
                {
                    return employee;
                }
            }
            catch (Exception ex)
            {
            }
                return null;
        }
    }
}
