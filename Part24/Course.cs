//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Part24
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
        }
    
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
