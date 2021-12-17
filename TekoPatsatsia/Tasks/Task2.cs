using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekoPatsatsia.Tasks
{
    public class Task2
    {
        public static int MinSplit(int amount)
        {
            var n = 0;

            if (amount >= 50)
            {
                n = amount / 50;
                amount %= 50;
            }
            if (amount >= 20)
            {
                n += amount / 20;
                amount %= 20;
            }
            if (amount >= 10)
            {
                n += amount / 10;
                amount %= 10;
            }
            if (amount >= 5)
            {
                n += amount / 5;
                amount %= 5;
            }
            if (amount >= 1)
            {
                n += amount / 1;
            }
            return n;
        }
	}
}
