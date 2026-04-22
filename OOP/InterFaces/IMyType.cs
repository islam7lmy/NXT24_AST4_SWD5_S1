using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    // Interface: is a contract that defines a set of
    // methods, properties, events, or indexers that a class or struct must implement.
    internal interface IMyType
    {
        /// What You Can Write Inside The Interface?
        /// 1. method signature
        /// 2. property signature
        /// 3. event signature
        /// 4. indexer signature
        /// 5. Default Implementation (C# 8.0 +)

        /// Default Access Modifier Inside The Interface is Public
        /// Private Access Modifier Is Not Allowed Inside The Interface

        ///property signature
        int Salary { get; set; }

        ///Method signature
        void Myfun();

        ///Default Implementation
        void Print()
        {
            Console.WriteLine("Hello I am Default Implementation");
        }
    }

    interface IMyType2
    {
        public int age { get; set; }
    }


    class MyType : IMyType , IMyType2  //=>Implementation the interface
    {
        ///clr will generate backing field [hidden private field]
        public int Salary { get; set; }
        public int age { get; set; }

        //int salary;
        //public int Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }
        //}

        public void Myfun() { Console.WriteLine("Hello"); }

        
    }


    class test
    {
        private int myVar; //field

        public int MyVar //propert
        {
            get { return myVar; }
            set { myVar = value; }
        }

        ///clr will generate backing field [hidden private field]
        public int Salary { get; set; }
    }
}
