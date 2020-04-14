using CoreWebAPI.Controller;
using CoreWebAPI.Models;
using CoreWebAPI.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace CoreWebAPI.Tests
{
    /// <summary>
    /// Testing Class for API Services
    /// </summary>
    public class APITestClass 
    {
        private static AppDbContext context = new AppDbContext();

        private static SqlEmployeeService service = new SqlEmployeeService(context);
        //APIController service = new APIController(service1);
        /// <summary>
        /// Test method to check adding of employee
        /// </summary>
        [Fact]
        public void can_AddEmployee()
        {
            //context.ChangeTracker.Entries();
            //Arrange
            EmployeeModel expected = null;
            EmployeeModel employee = new EmployeeModel();
            employee.EmpName = "Roshan";
            employee.Department = "Accounts";
            employee.Age = 23;
            employee.UserName = "Roshan";
            employee.Password = "Roshan";

            //Act
            //EmployeeModel actual = service.AddEmployee(employee);
            var actual = service.AddEmployee(employee);
            //Assert.ThrowsAny<InvalidOperationException>("Exception", () => service.AddEmployee(employee));
            //EmployeeModel actual = service.AddEmployee(new EmployeeModel
            //{EmpName = "Roshan", Department = "Accounts", Age = 23, UserName = "Roshan", Password = "Roshan"});
            Assert.Equal(expected, actual);
        }
        /// <summary>
        /// Test method to check deletion of employee
        /// </summary>
        [Fact]
        public void can_DeleteEmployee()
        {
            //Arrange
            int expected = 0;
            int send = 21;
            //Act
            int actual = service.DeleteEmployee(send);
            Assert.Equal(expected, actual);
        }
        /// <summary>
        /// Test method to get all employees
        /// </summary>
        [Fact]
        public void can_GetAllEmployee()
        {
            SqlEmployeeService service2 = new SqlEmployeeService(context);
            List<EmployeeModel> expected = new List<EmployeeModel>();
                expected = null;
                List<EmployeeModel> actual = service2.GetAllEmployee();
                Assert.Equal(expected, actual);
        }
        /// <summary>
        ///  Test method to update employee
        /// </summary>
        [Fact]
        public void can_UpdateEmployee()
        {
            //Arrange
            bool expected = false;
            EmployeeModel employee = new EmployeeModel();
            employee.EmpId = 18;
            employee.EmpName = "Siddu";
            employee.Department = "Accounts";
            employee.Age = 23;
            employee.UserName = "Siddu";
            employee.Password = "Siddu  ";

            //Act
            bool actual = service.UpdateEmployee(employee);
            Assert.Equal(expected, actual);
        }
        [Fact(Skip = "Just")]
        public void GetEmployee()
        {
            throw new NotImplementedException();
        }
        [Fact(Skip = "Just")]
        public void GetLogin()
        {
            throw new NotImplementedException();
        }
    }
}
