using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Part8
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Employee>().MapToStoredProcedures
                (p => p.Insert(x=>x.HasName("InsertEmployee")));

            modelBuilder.Entity<Employee>().MapToStoredProcedures
                (p => p.Update(x => x.HasName("UpdateEmployee")));

            modelBuilder.Entity<Employee>().MapToStoredProcedures
                (p => p.Delete(x => x.HasName("DeleteEmployee")));*/

            modelBuilder.Entity<Employee>().MapToStoredProcedures
                (
                    p => p.Insert(i => i.HasName("InsertEmployee")
                                        .Parameter(n=>n.Name, "EmployeeName")
                                        .Parameter(n => n.Gender, "EmployeeGender")
                                        .Parameter(n => n.Salary, "EmployeeSalary"))
                          .Update(u => u.HasName("UpdateEmployee")
                                        .Parameter(n => n.Id, "EmployeeId")
                                        .Parameter(n => n.Name, "EmployeeName")
                                        .Parameter(n => n.Gender, "EmployeeGender")
                                        .Parameter(n => n.Salary, "EmployeeSalary"))
                          .Delete(d => d.HasName("DeleteEmployee")
                                        .Parameter(n => n.Id, "EmployeeId"))
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}