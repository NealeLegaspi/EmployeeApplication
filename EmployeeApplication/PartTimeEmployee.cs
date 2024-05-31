using EmployeeApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }

        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle, double basicSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            JobTitle = jobTitle;
            BasicSalary = basicSalary;
        }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            double salary = hoursWorked * ratePerHour;
        }
    }
}
