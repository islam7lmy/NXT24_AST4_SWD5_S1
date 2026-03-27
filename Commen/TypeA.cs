using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    /// What You Can Write Inside The Namesapce?
    /// enum
    /// struct
    /// class
    /// interface
    /// delegate
    /// record

    /// What You Can Write Inside The Enum?
    /// only labels refer to numbers

    /// What You Can Write Inside The Class Or Struct?
    /// variables => fields (attributes)
    /// functions => methods
    /// constructors => special method
    /// properties
    /// events
    /// indexers

    /// What You Can Write Inside The Interface?
    /// 1. method signature
    /// 2. property signature
    /// 3. event signature
    /// 4. indexer signature
    /// 5. Default Implementation (C# 8.0 +)

    /// Allowed Access Modifiers Inside The Namespace 
    /// public 
    /// internal [default Access Modifier]
    
    //enum myp
    //{
    //    None = 0,
    //    excute
    //}

    public class TypeA
    {
        /// Allowed Access Modifiers Inside The class 
        /// 1. private [default]
        /// 2. private protected
        /// 3. protected
        /// 4. internal
        /// 5. internal protected
        /// 6. public

        int x; // private
        internal int y; //same assembly only
        public int z; //all




        void test()
        {
            //myp p = new myp();

            x = 1; 
            y = 2; 
            z = 3;
        }
    }
}
