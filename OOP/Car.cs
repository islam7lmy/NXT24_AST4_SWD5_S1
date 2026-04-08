using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        #region FullProperty [not recomended if no logic will be apply]
        //private int id; //field [attribute]

        //public int Id //property
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //private string model;

        //public string Model
        //{
        //	get { return model; }
        //	set { model = value; }
        //}

        //private int speed;

        //public int Speed
        //{
        //	get { return speed; }
        //	set { speed = value; }
        //} 
        #endregion

        #region Automatic Property => backing field
        /// clr will generate hidden private field  [backing field]
        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        #endregion

        /// if no user-defined constructor exists,
        /// clr will generate empty paramterless constructor
        //public Car() { } //=> do nothing

        /// if you write user-defined constructor
        /// clr will no longer generate empty paramterless constructor
        public Car(int id, string model, int speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
            Console.WriteLine("ctor 04");
        }

        public Car(int id, string model): this(id,model,120) //constructor chaning
        {
            //Id = id;
            //Model = model;
            //Speed = 120;
            Console.WriteLine("ctor 03");
        }
        public Car(int id) : this(id,"BMW")
        {
            //Id = id;
            //Model = "BMW";
            //Speed = 120;
            Console.WriteLine("ctor 02");
        }

        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 120;
            Console.WriteLine("ctor 01");
        }

    }
}
