using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebFrontEnd.Models
{
    public class Employee
    {
        [Required]
        public int EmpId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
