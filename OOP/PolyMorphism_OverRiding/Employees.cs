using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void MyFun01()
        {
            Console.WriteLine("I am Employee");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"Employee: id = {Id} , name = {Name} , age = {Age}");
        }
        public void MyFun04()
        {
            Console.WriteLine("I am method to inhert");
        }
    }

    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        ///static binding
        public new void MyFun01()
        {
            Console.WriteLine("I am FullTime Employee");
        }
        ///dynamic binding
        public override void MyFun02()
        {
            Console.WriteLine($"FullTime Employee: id = {Id} , name = {Name} , age = {Age} , salary = {Salary}");
        }

        public void MyFun03()
        {
            Console.WriteLine();
        }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }
        public new void MyFun01()
        {
            Console.WriteLine("I am PartTime Employee");
        }
        ///dynamic binding
        public override void MyFun02()
        {
            Console.WriteLine($"PartTime Employee: id = {Id} , name = {Name} , age = {Age} , hourRate = {HourRate} , countOfHours = {CountOfHours}");
        }
    }

    class FreeLance : Employee
    {

    }
}
