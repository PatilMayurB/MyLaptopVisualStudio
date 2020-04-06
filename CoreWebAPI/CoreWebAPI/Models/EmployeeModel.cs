using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; } 
        public string EmpName { get; set; }
        public string Department { get; set; }
        public int Age { get; set; } // = 1;
        public string UserName { get; set; } // = "default";
        public string Password { get; set; } // = "default";
    }
}
