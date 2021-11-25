using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part11
{
    public class EmployeeRepository
    {
        readonly EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        public List<Employee> GetEmployees()
        {
            return employeeDBContext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            employeeDBContext.Employees.Add(employee);
            employeeDBContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee employeeToUpdate = employeeDBContext.Employees
                .SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeToUpdate.EmployeeId = employee.EmployeeId;
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.Mobile = employee.Mobile;
            employeeToUpdate.Landline = employee.Landline;

            employeeDBContext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            Employee employeeToDelete = employeeDBContext.Employees
                .SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeDBContext.Employees.Remove(employeeToDelete);
            employeeDBContext.SaveChanges();
        }

    }
}