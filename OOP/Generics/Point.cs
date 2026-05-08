using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public override bool Equals(object? obj)
        {
            //this vs obj
            Point p1 =(Point) obj; // explicit casting [unsafe]
            return this.X == p1.X && this.Y == p1.Y;
            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
