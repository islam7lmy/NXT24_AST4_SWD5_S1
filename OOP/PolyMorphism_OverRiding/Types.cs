using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    /// base type
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }

        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA: A = {A}");
        }
    }

    /// drived type
    class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A , int _B) : base(_A)
        {
            B = _B;
        }

        /// hiding => new keyword
        /// static binded
        public new void MyFun01()
        {
            Console.WriteLine("I am Base [Child]");
        }

        /// override
        /// dynamic binded
        // Must be Non-Private Virtual
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB: A = {A} , B = {B}");
        }

        public static void MyFun03()
        {
            Console.WriteLine("I am drived class method");
        }
    }

    class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int _A , int _B , int _C) : base(_A , _B)
        {
            C = _C;
        }

        /// hiding => new keyword
        /// static binded
        public new void MyFun01()
        {
            Console.WriteLine("I am Grand [Child]");
        }

        /// override
        /// dynamic binded
        // Must be Non-Private Virtual
        public override void MyFun02()
        {
            Console.WriteLine($"TypeC: A = {A} , B = {B} , C = {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C , int _D) : base(_A, _B, _C)
        {
            D = _D;
        }
        ///static binding
        /// allow childs to use it as dynamic binding
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeD: A = {A} , B = {B} , C = {C} , D = {D}");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int _A, int _B, int _C, int _D, int _E) : base(_A, _B, _C, _D)
        {
            E = _E;
        }
        ///dynamic binding
        public override void MyFun02()
        {
            Console.WriteLine($"TypeE: A = {A} , B = {B} , C = {C} , D = {D} , E = {E} ");
        }
    }

}
