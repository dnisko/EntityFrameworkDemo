//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Part22
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
    }
}
