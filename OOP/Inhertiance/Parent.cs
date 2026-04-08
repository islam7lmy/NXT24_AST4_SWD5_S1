using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    ///base class
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        ///clr will generate parameter less constructor
        //public Parent()
        //{

        //}

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Parent Ctor");
        }

    }

    class Parent2
    {
        public int X { get; set; }
    }

    ///derived class
    class child : Parent //,Parent2 => multi inhertiance not allowed in C#
    {
        //public int X { get; set; }
        //public int Y { get; set; }
        public int Z { get; set; }

        ///clr will generate parameter less constructor
        //public child() : base() {}

        public child(int x, int y, int z) : base(x,y)
        {
            //X = x;
            //Y = y;
            Z = z;
            Console.WriteLine("Child Ctor");
        }
    }
}
