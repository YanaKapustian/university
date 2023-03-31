using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR17_kapustian
{
    public abstract class Triad
    {
        protected int First;
        protected int Second;
        protected int Third;

        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public int GetFirst { get { return First; } }
        public int GetSecond { get { return Second; } }
        public int GetThird { get { return Third; } }


        public virtual void IncrementFirst()
        {
            First++;
        }

        public virtual void IncrementSecond()
        {
            Second++;
        }

        public virtual void IncrementThird()
        {
            Third++;
        }
    }


}
