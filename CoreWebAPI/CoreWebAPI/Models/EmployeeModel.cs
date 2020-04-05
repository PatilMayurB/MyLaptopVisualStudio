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
    }
}
