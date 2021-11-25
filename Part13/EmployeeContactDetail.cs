using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part13
{
    public class EmployeeContactDetail
    {
        public int EmployeeID { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string LandLine { get; set; }

        public Employee Employee { get; set; }
    }
}