using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    ///not fully implmeneted
    abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        ///signature
        ///method not impemented => 
        ///virtual method => a method that is declared in a base class and can be overridden in a derived class.
        public abstract double Perimeter { get; }

        ///signature
        /// abstract method => a method that is declared in an abstract class but 
        /// does not have an implementation.
        /// virtual method => a method that is declared in a base class and can be overridden in a derived class.

        public abstract double CalcArea();

        public virtual double CalcAreaImplmented()
        {
            return Dim01 + Dim02;
        }
    }

    abstract class Rectshape : Shape
    {
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    class Squere : Rectshape
    {
        //public double Dim01 { get; set; }

        public override double Perimeter { get { return Dim01 * 4; } }

        //public override double CalcArea()
        //{
        //    return Dim01 * Dim01;
        //}

    }

    class Rectangle : Rectshape
    {
        //public double Dim01 { get; set; }
        //public double Dim02 { get; set; }

        public override double Perimeter { get { return (Dim01 + Dim02) * 2; } }

        //public override double CalcArea()
        //{
        //    return Dim01 * Dim02;
        //}
    }

    class Circle : Shape
    {
        //public double Dim01 { get; set; }

        public override double Perimeter { get { return 2 * 3.14 * Dim01; } }

        public override double CalcArea()
        {
            return 3.14 * Dim01 * Dim01;
        }
    }
}
