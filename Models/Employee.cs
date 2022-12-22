using System;

namespace WPFDB.Models
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Position { get; set; } = String.Empty;
        public string Salary { get; set; } = String.Empty;
    }
}