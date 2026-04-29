using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operator_Overloading
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal Detuction { get { return Salary * .2m; } }
    }


    internal class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string FullAddress { get; set; }
        public decimal NetSalary { get; set; }
    }
}
