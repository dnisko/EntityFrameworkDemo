using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part23
{
    public class Student
    {
        public int StudentID { get;set;}
        public string StudentName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}