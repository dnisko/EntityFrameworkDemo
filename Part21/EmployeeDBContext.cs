using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part21
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<PermanentEmployee>().ToTable("PermanentEmployees");
            modelBuilder.Entity<ContractEmployee>().ToTable("ContractEmployees");

            base.OnModelCreating(modelBuilder);
        }
    }
}