using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Point
    {
        /// What You Can Write Inside The Class Or Struct?
        /// 1. Fields (Attributes) => varibles
        /// 2. Mthods => Functions
        /// 3. Constructor => Special Method
        /// 4. Properties
        /// 5. Events
        /// 6. Indexers

        public int X;
        public int Y;

        /// CLR will always Generate Parameterless Constructor
        //public Point()
        //{
        //    X = default;
        //    Y = default;
        //}
        /// to initialize all attributes with default value based on it's daatatype
        /// You Can't Create User-Defined Parameterless Constructor Inside Struct (Except C# 10.0)

        /// User Defined Constructor is a Special Function 
        /// (Named With The Name of its Class and Has No Return Type)
        public Point(int _X , int _Y)
        {
            X = _X;
            Y = _Y;
        }
    }
}
