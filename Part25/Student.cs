using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part25
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}