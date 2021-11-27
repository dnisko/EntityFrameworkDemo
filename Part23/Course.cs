using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part23
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}