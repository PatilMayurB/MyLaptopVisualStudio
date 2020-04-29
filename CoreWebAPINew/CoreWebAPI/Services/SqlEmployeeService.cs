using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPI.Models;
/// <summary>
/// Class Interacting with Database through DbContext
/// </summary>
namespace CoreWebAPI.Services
{

    public class SqlEmployeeService : IEmployeeService
    {
        private AppDbContext context;
        /// <summary>
        /// Dependency Injection of DbContext
        /// </summary>
        /// <param name="context"></param>
        public SqlEmployeeService(AppDbContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// Adding an employee to Database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            try
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return employee;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        /// <summary>
        /// Deleting an employee from Database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteEmployee(int id)
        {
            try
            {
                var employeeFound = context.Employees.Find(id);
                context.Employees.Remove(employeeFound);
                context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        /// <summary>
        /// Method to get all employees from Database
        /// </summary>
        /// <returns></returns>
        public List<EmployeeModel> GetAllEmployee()
        {
            try
            {
                return context.Employees.ToList();
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        /// <summary>
        /// Method to get a single employee from Database
        /// </summary>
        /// <returns></returns>
        public EmployeeModel GetEmployee(int id)
        {
            try
            {
                var employee = context.Employees.Where(a => a.EmpId == id).SingleOrDefault();
                return employee;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        /// <summary>
        /// Method to check login credentials
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Method to update employee details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool UpdateEmployee(EmployeeModel employee)
        {
            try
            {
                context.Employees.Update(employee);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { 
            }
            return false;
        }
    }
}
