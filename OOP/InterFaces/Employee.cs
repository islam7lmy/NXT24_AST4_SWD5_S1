using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    internal class Employee : ICloneable , IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary} :: {Address}";
        }

        /// default constructor => empty parameterless constructor
        public Employee()
        {
            
        }

        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        /// and initializes the new object with the values of the existing object.
        public Employee(Employee emp)
        {
            //this keyword  is used to refer the current instance of the class
            //base keyword is used to refer the base class of current class [Parent Class]

            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Salary = emp.Salary;
            this.Address = emp.Address;
        }

        public static Employee DeepCopy(Employee emp)
        {
            //return new Employee()
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Salary = emp.Salary,
            //    Address = emp.Address,
            //};

            return new Employee(emp);
        }

        public object Clone()
        {
            //this keyword refer to object calling method

            return new Employee(this);
        }

        ///+ve : this > obj
        ///-ve : this < obj
        ///0 : this == obj
        //public int CompareTo(object? obj)
        //{
        //    Employee other = (Employee) obj; ///explicit casting //not save cast
        //    if (this.Salary > other.Salary)
        //        return +1;
        //    else if (this.Salary < other.Salary)
        //        return -1;
        //    else return 0;
        //}

        public int CompareTo(object? obj)
        {
            Employee other = (Employee)obj; ///explicit casting //not save cast
            if (this.Id > other.Id)
                return +1;
            else if (this.Id < other.Id)
                return -1;
            else return 0;
        }
    }
}
