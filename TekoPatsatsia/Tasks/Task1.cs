using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekoPatsatsia.Tasks
{
    public class Task1
    {
        public static bool IsPalindrome(string text)
        {
            var arr = new char[text.Length];
            var j = 0;
            for (var i = text.Length - 1; i >= 0; i--)
            {
                arr[j] = text[i];
                j++;
            }
            var reverse = new string(arr);
            return reverse.Equals(text);
        }
	}
}
