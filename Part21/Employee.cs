using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Part21
{
    //[Table("Employees")]
    public abstract class Employee
    {
        [Column(Order = 1)]
        public int EmployeeID { get; set; }
        [Column(Order = 2)]
        public string FirstName{ get; set; }
        [Column(Order = 3)]
        public string LastName{ get; set; }
        [Column(Order = 4)]
        public string Gender { get; set; }
    }
}