using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    internal interface IMovable
    {
        void Forward();
        void Backward();
    }

    internal interface IFlayable
    {
        void Forward();
        void Backward();
    }

    class Car : IMovable
    {
        public void Backward() //implicit implementation
        {
            Console.WriteLine("Car is Moving Backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car is Moving Forward");
        }
    }

    class AirPlan : IMovable , IFlayable
    {
        //implicit implementation
        //use in case of the bahvior in all methods will be the same
        public void Forward() 
        {
            Console.WriteLine("AirPlan is Moving Forward");
        }

        //explicit implementation
        //use in case of the bahvior in all methods will not be the same
        void IMovable.Backward() 
        {
            Console.WriteLine("AirPlan is Moving Backward");
        }

        //explicit implementation
        //use in case of the bahvior in all methods will not be the same
        void IFlayable.Backward() //implicit implementation
        {
            Console.WriteLine("AirPlan is Flaying Backward");
        }

    }

}
