using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPI.Models;
using CoreWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPI.Controller
{
    [Route("api/")]
    [ApiController]
    //**** Even Controller will work but it has views****
    public class APIController : ControllerBase
    {
        private IEmployeeService service;
        public APIController(IEmployeeService service)
        {
            this.service = service;
        }
        //**** Adding an Employee ****
        [HttpPost]
        [Route("AddEmployee")]
        public ActionResult<EmployeeModel> addEmployee(EmployeeModel employee)
        {
            var addedEmployee = service.AddEmployee(employee);

            if (addedEmployee == null)
            {
                return NotFound();
            }
            return addedEmployee;
        }

        //****Gettling all employee details****
        [HttpGet]
        [Route("GetAllEmployee")]
        public ActionResult<List<EmployeeModel>> getAllEmployee()
        {
            var allEmployees = service.GetAllEmployee();

            if (allEmployees == null)
            {
                return NotFound();
            }
            return allEmployees;
        }
        //****Getting details of one Employee****
        [HttpGet]
        [Route("GetEmployee/{id}")]
        public EmployeeModel GetEmployee(int id)
        {
            var employee = service.GetEmployee(id);
            return employee;
        }
        //****Login Route, checks Username and Password****
        [HttpPost]
        [Route("GetLogin")]
        public ActionResult<EmployeeModel> getLogin(EmployeeModel employee)
        {
            var foundEmployee = service.GetLogin(employee);

            if (foundEmployee == null)
            {
                return NotFound();
            }
            return foundEmployee;
        }
    }
}