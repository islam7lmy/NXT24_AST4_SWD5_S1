using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    interface ISeries
    {
        public int Current { get; set; }

        public void GetNext();

        //public void Reset();
        public void Reset()
        {
            Current = 0;
        }
    }

    class SeriesByTwo : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 2;
        }

        //public void Reset()
        //{
        //    Current = 0;
        //}
    }

    class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }

        //public void Reset()
        //{
        //    Current = 0;
        //}
    }

    class SeriesByFour : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }

        //public void Reset()
        //{
        //    Current = 0;
        //}
    }

    class SeriesByFive : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 5;
        }

        //public void Reset()
        //{
        //    Current = 0;
        //}
    }
}
