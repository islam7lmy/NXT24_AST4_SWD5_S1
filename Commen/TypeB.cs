using Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    internal class TypeB
    {
        void test()
        {
            //myp p = new myp();
            TypeA a = new TypeA();
            //a.x = 1; //invalid
            a.y = 2; //valid
            a.z = 3; //valid
        }
    }
}

namespace test1
{
    class testclass
    {
        void test()
        {
            //myp p = new myp();
            TypeA a = new TypeA();
            //a.x = 1; //invalid
            a.y = 2; //valid
            a.z = 3; //valid
        }
    }
}
