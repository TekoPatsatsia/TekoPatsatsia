using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekoPatsatsia.Tasks
{
    public class Task4
    {
        public static bool IsProperly(string sequence)
        {
            var bracket = new Stack<char>();
            foreach (var t in sequence)
            {
                switch (t)
                {
                    case '(':
                        bracket.Push(t);
                        break;
                    case ')' when !bracket.Any():
                        return false;
                    case ')' when t != ')':
                        continue;
                    case ')' when bracket.Pop() != '(':
                        return false;
                }
            }
            return !bracket.Any();
        }
    }
}
