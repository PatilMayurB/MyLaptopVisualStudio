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
    }
}