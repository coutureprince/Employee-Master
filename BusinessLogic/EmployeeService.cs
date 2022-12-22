using System.Collections.Generic;
using System.Linq;
using WPFDB.Models;
using WPFDB.Context;

namespace WPFDB.BusinessLogic
{
    public class EmployeeService
    {
        ApplicationContext applicationContext;
        public EmployeeService()
        {
            applicationContext = new ApplicationContext();
        }
        public IEnumerable<Employee> Get()
        {
            return applicationContext.Employees.ToList();
        }
        public void Add(Employee employee)
        {
            applicationContext.Employees.Add(employee);
            applicationContext.SaveChanges();
        }
        public void Delete(Employee employee)
        {
            applicationContext.Employees.Remove(employee);
            applicationContext.SaveChanges();
        }
        public void Update(Employee employee)
        {
            applicationContext.Employees.Update(employee);
            applicationContext.SaveChanges();
        }
    }
}