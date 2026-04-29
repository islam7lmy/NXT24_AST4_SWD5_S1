using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        
        public static Complex operator +(Complex a , Complex b)
        {
            /// ? null propgation ?? null colasicning
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)
            };
        }

        public static Complex operator ++(Complex a)
        {
            /// ? null propgation ?? null colasicning
            return new Complex()
            {
                Real = (a?.Real ?? 0) + 1,
                Imag = (a?.Imag ?? 0) + 1
            };
        }

        public static Complex operator --(Complex a)
        {
            /// ? null propgation ?? null colasicning
            return new Complex()
            {
                Real = (a?.Real ?? 0) - 1,
                Imag = (a?.Imag ?? 0) - 1
            };
        }

        public static bool operator >(Complex a, Complex b)
        {
            if (a.Real == b.Real)
                return a.Imag > a.Imag;
            else
                return a.Real > b.Real;
        }

        public static bool operator <(Complex a, Complex b)
        {
            if (a.Real == b.Real)
                return a.Imag < a.Imag;
            else
                return a.Real < b.Real;
        }
        public static bool operator ==(Complex a, Complex b)
        {
            if (a.Real == b.Real)
                return a.Imag == a.Imag;
            else
                return false;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

    }
}
