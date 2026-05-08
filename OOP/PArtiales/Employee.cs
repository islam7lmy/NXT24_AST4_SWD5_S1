using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PArtiales
{
    internal partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary} :: {Address}";
        }

        ///partial method
        ///don't have acces modiffier
        ///don't have retrun type
        partial void test();
    }

    partial class Employee
    {
        public int Age { get; set; }
        public string City { get; set; }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        //partial void test()
        //{
        //    Console.WriteLine("I am Partial method");
        //}
    }
}
