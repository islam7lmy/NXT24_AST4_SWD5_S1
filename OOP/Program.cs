//using Commen;
using OOP.Inhertiance;
using OOP.PolyMorphism_OverRiding;
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            /// Access Modifiers Types
            /// 1. private
            /// 2. private protected
            /// 3. protected
            /// 4. internal
            /// 5. internal protected
            /// 6. public

            //myp p = new myp();

            //TypeA a = new TypeA();
            ////a.x = 1; //invalid
            ////a.y = 2; //invalid
            //a.z = 3; //valid

            //TypeC C = new TypeC();
            //C.x = 1; //invalid
            //C.y = 2; //invalid
            //C.z = 3; //valid
            #endregion

            #region Struct
            #region Ex:01 Point
            //Point P1;
            /////Allocate 8 Unintialized Bytes For The Struct in The Stack Memory
            /////Console.WriteLine(P1); //Invalid because the struct is not initialized

            ////P1.X = 10;
            ////P1.Y = 20;
            ////Console.WriteLine(P1); //Valid because the struct is initialized

            //P1 = new Point(); //default constructor of the struct
            ///// new keyWord  just for select Constructor of th struct 
            ///// will initialize the struct with default values (0 for int, null for reference types, etc.)

            //P1 = new Point(10,20); //user defined constructor of the struct
            #endregion
            #region Ex:02 Employee
            //Employee emp = new Employee();
            //emp.SetName("Ahmed Ali Mohamed Ahmed Ibrahem abbas");
            //Console.WriteLine(emp.GetName()); 

            //emp.Salary = 2000; //property setter will check the value and save 3000 instead of 2000 because it's less than the minimum salary
            //Console.WriteLine(emp.Salary); //property getter will return the value of salary which is 3000 because the setter saved 3000 instead of 2000

            ////emp.Age = 20; //invalid because the setter of the Age property is private and can't be accessed outside the struct
            //Console.WriteLine(emp.Age);

            //Console.WriteLine(emp.Deduction);
            #endregion
            #region Ex:03 PhoneBook
            /// number => name
            //PhoneBook book = new PhoneBook();
            //book.Numbers; //invalid because it's private and can't be accessed outside the struct
            //book.Names; //invalid because it's private and can't be accessed outside the struct
            //book.size; //invalid because it's private and can't be accessed outside the struct

            //Console.WriteLine(book.Size);

            //book.AddContact("Ahmed", 1234567890);
            //book.AddContact("Ali", 9876543210);
            //book.AddContact("Mohamed", 5555555555);
            //book.AddContact("Ibrahem", 1111111111);

            //book.SetContactByName("Ahmed", 0128545485); // using method to update the number of Ahmed
            //book["Ahmed"] = 0128545485; // using indexer to update the number of Ahmed

            //Console.WriteLine(book.GetContactByName("Ahmed")); // using method to get the number of Ahmed
            //Console.WriteLine(book["Ahmed"]); // using indexer to get the number of Ahmed

            //book.RemoveContact("Ali"); // using method to remove Ali from the phone book

            //for (int i = 0; i < book.Size; i++)
            //{
            //    //Console.WriteLine(book.GetContactByIndex(i));
            //    Console.WriteLine(book[i]);
            //}

            #endregion
            #endregion

            #region Class 
            #region EX:Car
            //Car c1; //class
            /// declare reference => refer to null 
            /// allocate 4 bytes in stack uninitilized
            /// zero bytes has been allocated in heap
            //c1.Id = 1; //invalid
            //c1.Model = "marcides";//invalid
            //c1.Speed = 200;//invalid

            //c1 = new Car();
            ///new
            ///1. allocate required number of bytes in heap
            ///2. initialize all allocated bytes with default value based on it's datatype
            ///3. call user-defined constructor if exists
            ///4. assign ther reference [c1] to allocated object in heab

            //Point p1; //struct
            //p1.X = 10; 
            //p1.Y = 10;

            //p1 = new Point(); ///new => just for select constructor


            //Car c1 = new Car(); //default 
            //Point p1 = new Point();//default 

            //Car c1 = new Car(); // text to print
            //Car c2 = new Car(20);
            //Car c3 = new Car(20, "marcides");
            //Car c4 = new Car(20, "marcides", 200); 
            #endregion
            #region EX:Inhertance
            //Parent p1 = new Parent(10,20); //"Parent Ctor"
            //child c1 = new child(10, 20, 30); //"Parent Ctor"  "Child Ctor"
            #endregion
            #region RealationShip Between Class
            ///inhertance child is a parent , dog is an animal
            ///Aggregation has a
            /// 1. Composition => Room has Walls
            /// 2. Association => Room has Chairs
            #endregion

            #region Class                        vs    Struct
            //Car c = new Car();                       Point p1 = new Point(); //x=0 , y=0
            //Car c2 = c;                              Point p2 = p1; //x=0 , y=0
            //c2.Id = 30;                              p2.X = 30;//x=30 , y=0
            //Console.WriteLine(c.Id); /*30*/          Console.WriteLine(p1.X);  /*0*/ 
            /// complex data                     ||  simple data [size of data < 16 byte] 
            /// 1. reference type                ||  1. value type
            /// 2. support all oop pailers       ||  2. suport encabsulation && overriding
            /// 3. all access modifiers(private) ||  3. private , public , internal (public)
            /// 4. clr will generate             ||  4. clr will always generate parameter less constructor
            /// parameter less constructor 
            /// if no user-defined 
            /// constructor exists
            #endregion
            #endregion

            #region PolyMorphism
            #region OverLoading
            //Sum(10.0, 20);
            //Console.WriteLine();
            #endregion
            #region OverRiding
            //TypeA a = new TypeA(10);
            //a.MyFun01();
            //a.MyFun02();

            //TypeB b = new TypeB(10,20);
            //b.MyFun01();
            //b.MyFun02();
            #endregion
            #endregion

            #region Binding
            #region What is binding
            /// reference from base type  =>  object  from drived type
            //Parent p1;
            ///// reference 
            //p1 = new child(10,20,30);
            ///reference => object 

            //TypeA typeA = new TypeB(10, 20);

            /////TypeB typeB = (TypeB)(new TypeA(10)); ///not binding
            ////typeA.A = 10;
            //////typeA.B = 20; //not valid
            ////typeA.MyFun01();
            ////typeA.MyFun02();
            ///////typeA.MyFun03(); //not valid


            /////2.1 static binding [early binding] => new keyword
            /////Compiler Will Bind Function Call Based On Reference Type NOT Object Type
            /////at complition time
            //typeA.MyFun01(); ///will run method in base class

            /////2.2 dynamic binding [late binding] => override keyword
            ///// Will Bind Function Call Based On Object Type NOT Reference Type
            /////at runtime
            //typeA.MyFun02(); ///will run method in dervied class
            #endregion
            #region Why Need Binding
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            ////OOP.PolyMorphism_OverRiding.Employee reference = fullTimeEmployee;
            /////// two reference [fulltimeemployee, reference] => refer to object of type full time employee
            ////ProcessEmployee(reference);/// reference , object
            /////OOP.PolyMorphism_OverRiding.Employee reference = fullTimeEmployee;  //copy address

            //fullTimeEmployee.MyFun01(); //static binded
            //fullTimeEmployee.MyFun02(); //dynamic binded
            //fullTimeEmployee.MyFun04(); //just inherted

            //Console.WriteLine("after calling ");

            //ProcessEmployee(fullTimeEmployee);

            ////ProcessEmployee(fullTimeEmployee);

            //Console.WriteLine("Parttime employee calling");

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //ProcessEmployee(partTimeEmployee);

            #endregion
            #region More Practies on binding
            //TypeA typeA = new TypeC(1, 2, 3); //indirect parent
            //typeA.A = 10;
            ////typeA.B = 20;///not valid
            ////typeA.C = 30;///not valid
            //typeA.MyFun01(); // static binding method => will run reference method
            //typeA.MyFun02(); // dynamic binding method => will run object method


            //TypeB typeB = new TypeC(1, 2, 3); //indirect parent
            //typeB.A = 10;
            //typeB.B = 20;///valid
            ////typeB.C = 30;///not valid
            //typeB.MyFun01(); // static binding method => will run reference method
            //typeB.MyFun02(); // dynamic binding method => will run object method

            

            #endregion
            #endregion
        }
        #region PolyMorphism 1. Function OverLoading
        //1.data type of paramaters
        //2.count of paramaters
        //3.order if not same data type of paramaters
        public static int Sum(int y , int x)
        {
            return x + y;
        }

        public static int Sum(int x, int y , int z)
        {
            return x + y + z;
        }

        public static int Sum(double x, double y)
        {
            return (int)(x + y);
        }

        //public static double Sum(double x, double y) // not overloading
        //{
        //    return (int)(x + y);
        //}

        public static int Sum(int x, double y)
        {
            return (int)(x + y);
        }

        public static int Sum(double x, int y)
        {
            return (int)(x + y);
        }
        #endregion

        #region Why Need Binding
        //public static void ProcessEmployee(OOP.Employee emp)
        //{
        //    //if (emp is not null)
        //    //{
        //    //    emp.MyFun01();
        //    //    emp.MyFun02();
        //    //}
        //}
        public static void ProcessEmployee(OOP.PolyMorphism_OverRiding.Employee emp)
        {
            if (emp is not null)
            {
                emp.MyFun01(); //static binded
                emp.MyFun02(); //dynamic binded
                emp.MyFun04(); //just inherted
            }
        }

        //public static void ProcessEmployee(FullTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}

        //public static void ProcessEmployee(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}

        //public static void ProcessEmployee(FreeLance emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}
        #endregion
    }
}
