using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekoPatsatsia.Tasks
{
    public class Task5
    {
        public static int CountVar(int count)
        {
            count++;
            return CountVariants(count);
        }
        private static int CountVariants(int stearCount)
        {

            if (stearCount > 1)
                return CountVariants(stearCount - 1) + CountVariants(stearCount - 2);
            else
            {
                return stearCount;
            }
        }
    }
}
