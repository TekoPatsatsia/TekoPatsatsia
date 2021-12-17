using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekoPatsatsia.Tasks
{
    public class Task3
    {
        public static int NotContains(int[] array)
        {
            int n = 1;
            while (array.Contains(n))
            {
                n++;
            }
            return n;
        }
    }
}
