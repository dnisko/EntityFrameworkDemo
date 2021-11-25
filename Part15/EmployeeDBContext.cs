using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Part15
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Map(m => m.Requires("IsTerminated")
                .HasValue(false))
                .Ignore(m => m.IsTerminated);

            base.OnModelCreating(modelBuilder);
        }
    }
}