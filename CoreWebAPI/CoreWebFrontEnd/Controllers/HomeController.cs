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
        public async Task<IActionResult> Details(int id)
        {
            Employee employee = new Employee();
            HttpClient client = employeeAPI.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/GetEmployee/{id}");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<Employee>(results);
            }
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            HttpClient client = employeeAPI.Initial();

            //Try without PostAsJsonSync
            var postData = client.PostAsJsonAsync<Employee>("api/AddEmployee", employee);
            postData.Wait();
            var result = postData.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Employee employee)
        {
            HttpClient client = employeeAPI.Initial();

            var postData = client.PostAsJsonAsync<Employee>("api/GetLogin", employee);
            postData.Wait();
            var result = postData.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
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
