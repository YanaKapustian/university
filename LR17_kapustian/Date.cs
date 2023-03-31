using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR17_kapustian
{
    public class Date : Triad
    {
        public Date(int year, int month, int day) : base(year, month, day)
        {
        }

        public override void IncrementFirst()
        {
            First++;
        }

        public override void IncrementSecond()
        {
            if (Second == 12)
            {
                Second = 1;
                IncrementFirst();
            }
            else
            {
                Second++;
            }
        }

        public override void IncrementThird()
        {
            if (Third == DateTime.DaysInMonth(First, Second))
            {
                Third = 1;
                IncrementSecond();
            }
            else
            {
                Third++;
            }
        }
    }
}
