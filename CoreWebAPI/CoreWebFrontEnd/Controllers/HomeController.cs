using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreWebFrontEnd.Models;
using CoreWebFrontEnd.Helper;
using System.Net.Http;
using Newtonsoft.Json;

namespace CoreWebFrontEnd.Controllers
{ 
    public class HomeController : Controller
    {
        EmployeeAPI employeeAPI = new EmployeeAPI();

        public async Task<IActionResult> Index()
        {
            List<Employee> employees = new List<Employee>();
            HttpClient client = employeeAPI.Initial();
            HttpResponseMessage res = await client.GetAsync("api/GetAllEmployee");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<Employee>>(results);
            }
            return View(employees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
