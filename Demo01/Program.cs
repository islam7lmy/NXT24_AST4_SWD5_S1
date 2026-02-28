using System.Text;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Demo01
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region Comment
            // line comment
            /*
             block comment
             */
            #endregion

            #region Value Type
            //int X;
            ///////int : C# Keyword
            ///////Allocation 4 UnInitialized Bytes in Stack

            //X = 5;
            ////Console.WriteLine(X);

            //Int32 Y;
            ///////Int32 : .NET Type BCL
            /////Allocation 4 UnInitialized Bytes in Stack

            //Y = X;

            //X += 1; // X = X + 1;

            //Console.WriteLine(X);

            //Console.WriteLine(Y);
            #endregion

            #region Reference Type
            //Point p1;
            ////// declaration of reference type variable p1
            ////// 4 bytes allocated in stack for p1, initialized to null
            ////// Zero Bytes Allocated at Heap

            //p1 = new Point();
            ////// new : operator to allocate memory in heap for Point object
            ////// 1.allocated required memory in heap for Point object (8 bytes for X and Y)
            ////// 2.initialized the allocated memory to default values (0 for X and Y)
            ////// 3.call user defined constructor to initialize the object (if any)
            ////// 4.assigned the address of allocated memory in heap to p1 variable in stack

            //Console.WriteLine(p1.GetHashCode());

            //Point p2 = new Point();

            //Console.WriteLine(p2.GetHashCode());



            //p2 = p1;
            //Console.WriteLine("************after assign**************");
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());
            //// p2 now holds the same address as p1, both p1 and p2 reference the same Point object in heap

            //p1.X = 5;

            //Console.WriteLine(p1.X);
            //Console.WriteLine(p2.X);
            #endregion

            #region Objcet
            //object O1 = new object();
            //object O2 = new object();

            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode());

            //O2 = O1;
            //Console.WriteLine("after assignment");

            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode());

            #endregion

            #region Fractions and Discards
            //for reading only
            //int X = 772_738_333; //_ is used as a digit separator for better readability of large numbers

            //float f = 15.3f;
            //double d = 15.3;
            //decimal m = 15.3m;
            #endregion

            #region Value type casting
            ///1. Implicit Casting (safe casting)
            //int X = 5;
            //long Y = X; // implicit casting from int to long, no data loss, safe casting
            //Y = 12345678901234;

            ///2. Explicit Casting (unsafe casting)
            //X = (int) Y;
            //Console.WriteLine(X);

            //unchecked
            //{
            //    X = (int)Y; // explicit casting from long to int, potential data loss, unsafe casting
            //    Console.WriteLine(X);
            //}

            //checked
            //{
            //    int Z = (int)Y; // explicit casting from long to int, potential data loss, unsafe casting
            //    unchecked
            //    {
            //        Console.WriteLine(Z);
            //    }
            //}

            ///3. parse (convert from string to any datatype)
            //int X = int.Parse(Console.ReadLine());
            //Console.Write("Please Enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("your age is " + age);

            ///4. try parse (convert from string to any datatype with error handling)
            //Console.Write("Please Enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age;
            //bool result = int.TryParse(Console.ReadLine(),out age);
            //if (result)
            //{
            //    Console.WriteLine("Hello " + name);
            //    Console.WriteLine("your age is " + age);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age input");
            //}
            //Console.WriteLine("hello");

            ///5. Convert Class (convert from any datatype to any datatype)
            //Console.Write("Please Enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("your age is " + age);
            #endregion

            #region Opertators

            #region Unary Operator
            //int X = 10;
            /////prefix [increment and then print]
            //Console.WriteLine(++X); // X = X + 1; Console.WriteLine(X);
            /////postfix [print and then increment]
            //Console.WriteLine(X++); // Console.WriteLine(X); X = X + 1;
            //Console.WriteLine(X);
            ///// prefix [decrement and then print]
            //Console.WriteLine(--X); // X = X - 1; Console.WriteLine(X);
            ///// postfix [print and then decrement]
            //Console.WriteLine(X--); // Console.WriteLine(X); X = X - 1;
            //Console.WriteLine(X);
            #endregion

            #region Binary Operator
            //int Sum, sub, mul, div, mod;
            //int num1 = 10, num2 = 3;
            //Sum = num1 + num2; // addition
            //sub = num1 - num2; // subtraction
            //mul = num1 * num2; // multiplication
            //div = num1 / num2; // division
            //mod = num1 % num2; // modulus 6 % 4 = 2 (remainder of division)

            //double div2 = 10.0 / 3;
            //double div2 = (double)10 / 3; // explicit casting to double for accurate division result
            //Console.WriteLine(div2);
            #endregion

            #region Assignment Operator
            //int X;
            //X = 5; // assignment operator, assigns the value 5 to variable X
            //X += 2; // X = X + 2; since X is not initialized, it will cause a compile-time error
            //X -= 1; // X = X - 1;
            //X *= 3; // X = X * 3;
            //X /= 2; // X = X / 2;
            //X %= 3; // X = X % 3;
            #endregion

            #region Relational Operator [Comparsion]
            //int num1 = 10, num2 = 20;
            //Console.WriteLine(num1 == num2); // equality operator, checks if num1 is equal to num2, returns false
            //Console.WriteLine(num1 != num2);
            //Console.WriteLine(num1 > num2);
            //Console.WriteLine(num1 < num2);
            //Console.WriteLine(num1 >= num2);
            //Console.WriteLine(num1 <= num2);
            #endregion

            #region Logical Operator
            //Console.WriteLine(!false); // logical NOT operator, negates the boolean value, returns true
            //Console.WriteLine(false && true); // logical AND operator, returns true if both operands are true, otherwise returns false
            //Console.WriteLine(true || false); // logical OR operator, returns true if at least one operand is true, otherwise returns false

            //Console.WriteLine(!((4 < 5) && (!(7 < 9) || 5 == 5)));
            #endregion

            #region Bitwise operator
            //Console.WriteLine(false & true); // bitwise AND operator, performs a bitwise AND operation on two boolean values, returns false
            //Console.WriteLine(true | false); // bitwise OR operator, performs a bitwise OR operation on two boolean values, returns true
            //Console.WriteLine(true ^ false); // bitwise XOR operator, performs a bitwise exclusive OR operation on two boolean values, returns true if exactly one operand is true, otherwise returns false
            #endregion

            #region Ternary operator [conditional operator]
            //int x = 4, y = 7, z = 9;
            //if(x>y)
            //    Console.WriteLine("x is greater than y");
            //else
            //    Console.WriteLine("y is greater than x");

            //Console.WriteLine(x > y ? "x is greater than y" : "y is greater than x");

            //bool flag = x > y ? true : false;
            #endregion

            #region Operator priorty
            /*
             * 1. unary operator (prefix)
             * 2. round brackets ()
             * 3. * / %
             * 4. + -
             */
            //int a = 20, b = 10, c = 15, d = 5, e;
            //e = (a + b) * c / d; //(20+10) * 15 / 5 = 30 * 15 / 5 = 450 / 5 = 90 
            //e = ((--a + b) * c) / d; // ((19 + 10) * 15) / 5 = (29 * 15) / 5 = 435 / 5 = 87
            //e = --a + b * c / d;//19+10*15/5=19+150/5=19+30=49
            #endregion
            #endregion

            #region string formating
            // Equation : 4 + 2 = 6
            //int X = 4, Y = 2;
            //string result = "Equation :" + X + " + " + Y + " = " + (X + Y);

            //string result = string.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);

            //string result = $"Equation : {X} + {Y} = {X + Y}";
            //Console.WriteLine(result);
            #endregion

            #region String Vs stringbuilder
            //Console.WriteLine("string");
            //string x = "Hello"; // syntex sugar for string x = new string("Hello");
            //Console.WriteLine(x.GetHashCode());
            //x += " World"; // string is immutable, so a new string object is created in heap with value "Hello World" and x now references the new string object, the old string object "Hello" is eligible for garbage collection
            ////x = "hello world";
            //Console.WriteLine(x.GetHashCode());
            //////////////////////////////////////////////
            //Console.WriteLine("string builder");
            //StringBuilder y = new StringBuilder();
            //y.Append("Hello"); // StringBuilder is mutable, so the same StringBuilder object is modified in heap to have the value "Hello" and y references the same StringBuilder object
            //Console.WriteLine(y.GetHashCode());
            //y.Append(" World"); // the same StringBuilder object is modified in heap to have the value "Hello World" and y references the same StringBuilder object, no new object is created, more memory efficient for string manipulation
            //Console.WriteLine(y.GetHashCode());
            //Console.WriteLine(y.ToString());
            #endregion

            #region Conditional Statements
            #region EX01
            #region if
            //Console.WriteLine("insert number of month in first Qurter of year:");
            //int month;
            //if (int.TryParse(Console.ReadLine(), out month))
            //{
            //    if (month == 1)
            //        Console.WriteLine("January");
            //    if (month == 2)
            //        Console.WriteLine("February");
            //    if (month == 3)
            //        Console.WriteLine("March");
            //    else 
            //        Console.WriteLine("number is out of range");


            //    if (month == 1)
            //        Console.WriteLine("January");
            //    else if (month == 2)
            //        Console.WriteLine("February");
            //    else if (month == 3)
            //        Console.WriteLine("March");
            //    else
            //        Console.WriteLine("number is out of range");
            //}
            //else
            //{
            //    Console.WriteLine("invalid input for month");
            //}
            #endregion
            #region switch
            //Console.WriteLine("insert number of month in first Qurter of year:");
            //int month;
            //int.TryParse(Console.ReadLine(), out month);
            ///// jump table
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 0:
            //        Console.WriteLine("invalid input for month");
            //        break;
            //    default:
            //        Console.WriteLine("number is out of range");
            //        break;
            //}
            #endregion
            #endregion

            #region EX02
            #region if
            //Console.WriteLine("enter your salary");
            //int salary;
            //if(int.TryParse(Console.ReadLine(), out salary))
            //{
            //    if (salary == 3000)
            //    {
            //        Console.WriteLine("option 3");
            //        Console.WriteLine("option 2");
            //        Console.WriteLine("option 1");
            //    }
            //    else if (salary == 2000)
            //    {
            //        Console.WriteLine("option 2");
            //        Console.WriteLine("option 1");
            //    }
            //    else if (salary == 1000)
            //    {
            //        Console.WriteLine("option 1");
            //    }
            //    else
            //    {
            //        Console.WriteLine("can not do any option");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}
            #endregion

            #region switch
            //Console.WriteLine("enter your salary");
            //int salary;
            //if (int.TryParse(Console.ReadLine(), out salary))
            //{
            //    switch (salary)
            //    {
            //        case 3000:
            //            Console.WriteLine("option 3");
            //            //Console.WriteLine("option 2");
            //            //Console.WriteLine("option 1");
            //            //break;
            //            goto case 2000;
            //        case 2000:
            //            Console.WriteLine("option 2");
            //            //Console.WriteLine("option 1");
            //            //break;
            //            goto case 1000;
            //        case 1000:
            //            Console.WriteLine("option 1");
            //            break;
            //        default:
            //            Console.WriteLine("can not do any option");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}
            #endregion

            #endregion
            #region Calculater
            // take number then opration then number and show result
            //calculator do (+ - * / %)
            //write program to do that and make it protictive

            //int num1, num2;
            //double result;
            //char op;
            //Console.WriteLine("enter first number");
            //if (!int.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.WriteLine("invalid format for first number");
            //    return;
            //}

            //Console.WriteLine("enter operation ( + - * / %)");
            //if (!(char.TryParse(Console.ReadLine(), out op))
            //    &&
            //    (op == '+' || op == '-' || op == '*' || op == '/' || op == '%'))
            //{
            //    Console.WriteLine("invalid format for operation");
            //    return;
            //}

            //Console.WriteLine("enter last number");
            //if (!int.TryParse(Console.ReadLine(), out num2))
            //{
            //    Console.WriteLine("invalid format for last number");
            //    return;
            //}

            //switch (op)
            //{
            //    case '+': result = num1 + num2; break;
            //    case '-': result = num1 - num2; break;
            //    case '*': result = num1 * num2; break;
            //    case '/':
            //        if (num2 != 0)
            //            result = (double)num1 / num2;
            //        else
            //        {
            //            Console.WriteLine("can not divide by zero");
            //            return;
            //        }
            //        break;
            //    case '%':
            //        if (num2 != 0)
            //            result = num1 % num2;
            //        else
            //        {
            //            Console.WriteLine("can not divide by zero");
            //            return;
            //        }
            //        break;
            //    default: return;
            //}
            //Console.WriteLine($"{num1} {op} {num2} = {result}");

            #endregion
            #endregion

            #region Loops Statment
            // print numbers from 1 to 10
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            #region For
            ///for(initilization; condtion; increment | decrement)
            ///body
            ///
            ///1. initilization
            ///2. check condtion
            ///3. if condtion true => do body code
            ///4. increment | decrement
            ///5. check condtion
            ///6. if condtion true => do body code
            ///7. increment | decrement

            //for (int i = 100; i <= 1_000_000; ++i) //i++ //i +=1 //i = i+1
            //    Console.WriteLine(i);

            //int i = 1; //initilization
            //for (; ; )
            //{
            //    if (i <= 10) //condtion
            //    {
            //        if (i % 2 == 0)
            //        {
            //            ++i;
            //            continue; ////skip the rest of the loop body and go to the next iteration
            //        }
            //        Console.WriteLine(i); //body
            //        ++i; //increment
            //    }
            //    else
            //        break; // exit the loop
            //}
            #endregion

            #region while
            //while(reader.Read())
            //{
            //
            //}
            //Console.WriteLine("insert 0 if you want to continue");
            //string input = Console.ReadLine();
            //while (input == "0")
            //{
            //    Console.WriteLine("hello");
            //    Console.WriteLine("insert 0 if you want to continue or any key if you want to exist");
            //    input = Console.ReadLine();
            //}

            //while (true)
            //{
            //    Console.WriteLine("insert first number");
            //    double num1;
            //    while (!double.TryParse(Console.ReadLine(), out num1))
            //        Console.WriteLine("wrong foramt, please insert first number");

            //    Console.WriteLine("insert opration");
            //    char op;
            //    while (!(char.TryParse(Console.ReadLine(), out op)
            //        && (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')))
            //        Console.WriteLine("wrong foramt, please insert opration");

            //    Console.WriteLine("insert last number");
            //    double num2;
            //    while (
            //        !double.TryParse(Console.ReadLine(), out num2)
            //        ||
            //        ((op == '/' || op == '%') && num2 == 0)
            //        )
            //        Console.WriteLine("wrong foramt, please insert last number");

            //    double result = 0;
            //    switch (op)
            //    {
            //        case '+': result = num1 + num2; break;
            //        case '-': result = num1 - num2; break;
            //        case '*': result = num1 * num2; break;
            //        case '/': result = num1 / num2; break;
            //        case '%': result = num1 % num2; break;
            //    }
            //    Console.WriteLine($"Eqution: {num1} {op} {num2} = {result}");
            //    Console.WriteLine("*********************************************");

            //}
            #endregion

            #region do while
            //for(int i = 11; i<=10; i++)
            //    Console.WriteLine(i);

            //int i = 11;
            //do
            //{
            //    Console.WriteLine(i);
            //} while (i <= 10);
            //do
            //{
            //    Console.WriteLine("insert first number");
            //    double num1;
            //    while (!double.TryParse(Console.ReadLine(), out num1))
            //        Console.WriteLine("wrong foramt, please insert first number");

            //    Console.WriteLine("insert opration");
            //    char op;
            //    while (!(char.TryParse(Console.ReadLine(), out op)
            //        && (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')))
            //        Console.WriteLine("wrong foramt, please insert opration");

            //    Console.WriteLine("insert last number");
            //    double num2;
            //    while (
            //        !double.TryParse(Console.ReadLine(), out num2)
            //        ||
            //        ((op == '/' || op == '%') && num2 == 0)
            //        )
            //        Console.WriteLine("wrong foramt, please insert last number");

            //    double result = 0;
            //    switch (op)
            //    {
            //        case '+': result = num1 + num2; break;
            //        case '-': result = num1 - num2; break;
            //        case '*': result = num1 * num2; break;
            //        case '/': result = num1 / num2; break;
            //        case '%': result = num1 % num2; break;
            //    }
            //    Console.WriteLine($"Eqution: {num1} {op} {num2} = {result}");
            //    Console.WriteLine("*********************************************");
            //    Console.WriteLine("if you want to do anthor calac enter 'y' or press any key to exit");
            //} while ((Console.ReadLine()).ToLower() == "y");
            #endregion

            #region Foreach
            //string text = Console.ReadLine();
            //foreach(char item in text)
            //    Console.WriteLine(item);

            //List<string> names = new List<string>()
            //{
            //    "ali",
            //    "ahmed",
            //    "sara"
            //};

            //for (int i = 0; i < names.Count; i++)  // to edit
            //    names[i] += "hello";

            ////vs

            //foreach (string item in names) //to display
            //    item += "hello"; //not valid
            #endregion
            #endregion

            #region Block scope
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i); //valid
            //}
            //Console.WriteLine(i); //not valid out of scope

            //while (!double.TryParse(Console.ReadLine(), out double x))
            //{
            //    //double x;
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine(x);//not valid out of scope

            ////double y;
            //if (!double.TryParse(Console.ReadLine(), out double y))
            //{
            //    int z = 0;
            //    Console.WriteLine(y);
            //}
            //Console.WriteLine(y);//valid
            //Console.WriteLine(z);//not valid out of scope

            //{
            //    int z = 0;
            //}
            //Console.WriteLine(z);
            //{
            //    int z = 0;
            //}
            //Console.WriteLine(z);
            #endregion

            #region arrays

            #endregion

            #region Boxing vs unboxing

            #endregion

            #region Nullable types

            #region Null propagation operator

            #endregion
            #endregion

            #region Functions

            #endregion
        }
    }
}