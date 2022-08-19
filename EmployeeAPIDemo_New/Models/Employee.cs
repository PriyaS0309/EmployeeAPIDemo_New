using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPIDemo_New.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
