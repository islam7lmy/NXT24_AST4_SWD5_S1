using Commen;
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
            PhoneBook book = new PhoneBook();
            //book.Numbers; //invalid because it's private and can't be accessed outside the struct
            //book.Names; //invalid because it's private and can't be accessed outside the struct
            //book.size; //invalid because it's private and can't be accessed outside the struct

            Console.WriteLine(book.Size); 
            #endregion
            #endregion
        }
    }
}
