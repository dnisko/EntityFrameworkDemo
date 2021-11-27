using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part22
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            GridView1.DataSource = from student in employeeDBContext.Students.ToList()
                                   from course in student.Courses.ToList()
                                   select new
                                   {
#pragma warning disable IDE0037 // Use inferred member name
                                       StudentName = student.StudentName,
#pragma warning restore IDE0037 // Use inferred member name
#pragma warning disable IDE0037 // Use inferred member name
                                       CourseName = course.CourseName
#pragma warning restore IDE0037 // Use inferred member name
                                   };
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            Course WCFCourse = employeeDBContext.Courses.FirstOrDefault(x => x.CourseID == 4);

            employeeDBContext.Students.FirstOrDefault(x => x.StudentID == 1).Courses.Add(WCFCourse);
            employeeDBContext.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            Course SQLServerCourse = employeeDBContext.Courses.FirstOrDefault(x => x.CourseID == 3);

            employeeDBContext.Students.FirstOrDefault(x => x.StudentID == 2).Courses.Remove(SQLServerCourse);
            employeeDBContext.SaveChanges();
        }
    }
}