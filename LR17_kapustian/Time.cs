using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR17_kapustian
{
    public class Time : Triad
    {
        public Time(int hour, int minute, int second) : base(hour, minute, second)
        {
        }

        public override void IncrementFirst()
        {
            if (First == 23)
            {
                First = 0;
            }
            else
            {
                First++;
            }
        }

        public override void IncrementSecond()
        {
            if (Second == 59)
            {
                Second = 0;
                IncrementFirst();
            }
            else
            {
                Second++;
            }
        }

        public override void IncrementThird()
        {
            if (Third == 59)
            {
                Third = 0;
                IncrementSecond();
            }
            else
            {
                Third++;
            }
        }
    }
}
