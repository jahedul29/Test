using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement_3.Models
{
    public class EmpClass
    {
        [Key] 
        public int EmpId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string EmpName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string EmpEmail { get; set; }

        [Required]
        public int Salary { get; set; }

    }
}
