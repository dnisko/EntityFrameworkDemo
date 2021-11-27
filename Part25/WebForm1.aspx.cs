using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part25
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            var query = from student in employeeDBContext.Students//.ToList()
                        from studentCourse in student.StudentCourses//.ToList()
                        select new
                        {
#pragma warning disable IDE0037 // Use inferred member name
                            StudentName = student.StudentName,
                            CourseName = studentCourse.Course.CourseName,
                            EnrolledDate = studentCourse.EnrolledDate
#pragma warning restore IDE0037 // Use inferred member name
                        };

            /*
             var query = from course in employeeDBContext.Courses//.ToList()
                        from studentCourse in course.StudentCourses//.ToList()
                        select new
                        {
#pragma warning disable IDE0037 // Use inferred member name
                            StudentName = studentCourse.Student.StudentName,
                            CourseName = course.CourseName,
                            EnrolledDate = studentCourse.EnrolledDate
#pragma warning restore IDE0037 // Use inferred member name
                        };
             */
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            StudentCourse WCFCourse = new StudentCourse
            {
                StudentID = 1,
                CourseID = 4,
                EnrolledDate = DateTime.Now
            };
            employeeDBContext.StudentCourses.Add(WCFCourse);
            employeeDBContext.SaveChanges();
            //employeeDBContext.Students.FirstOrDefault(x => x.StudentID == 1).Courses.Add(WCFCourse);
            //employeeDBContext.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            StudentCourse SQLServerCourse = employeeDBContext.StudentCourses.FirstOrDefault
                (
                    x => x.StudentID == 2 && x.CourseID == 3
                );
            employeeDBContext.StudentCourses.Remove(SQLServerCourse);
            employeeDBContext.SaveChanges();
            //EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            //Course SQLServerCourse = employeeDBContext.Courses.FirstOrDefault(x => x.CourseID == 3);

            //employeeDBContext.Students.FirstOrDefault(x => x.StudentID == 2).Courses.Remove(SQLServerCourse);
            //employeeDBContext.SaveChanges();
        }
    }
}