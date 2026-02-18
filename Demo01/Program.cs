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

            #endregion

            #region Opertators

            #endregion

            #region string formating

            #endregion

            #region Conditional Statements

            #endregion
        }
    }
}