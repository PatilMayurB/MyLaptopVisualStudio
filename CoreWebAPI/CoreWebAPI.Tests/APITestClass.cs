using CoreWebAPI.Models;
using CoreWebAPI.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace CoreWebAPI.Tests
{
    public class APITestClass 
    {
        [Fact]
        public void AddEmployee()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void GetAllEmployee()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void GetEmployee()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void GetLogin()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void UpdateEmployee()
        {
            EmployeeModel employee = new EmployeeModel();
            employee.EmpId = 18;
            employee.EmpName = "Siddu";
            employee.Department = "Accounts";
            employee.Age = 23;
            employee.UserName = "Siddu";
            employee.Password = "Siddu  ";
        }
    }
}
