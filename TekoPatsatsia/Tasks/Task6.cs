using System.Collections;

namespace TekoPatsatsia.Tasks
{
    public class Task6
    {
        private static readonly LinkedList<LinkedListNode<int>> Structure = new();
        private static readonly Hashtable HT = new();
        public static bool Insert(int val)
        {
            var node = new LinkedListNode<int>(val);
            Structure.AddLast(node);
            var retVal = false;

            if (!HT.ContainsKey(val))
            {
                var index = new LinkedList<LinkedListNode<int>>();
                index.AddLast(node);
                HT.Add(val, index);
                retVal = true;
            }
            else
            {
                var index = (LinkedList<LinkedListNode<int>>)HT[val]!;
                index.AddLast(node);
                retVal = false;
            }

            return retVal;
        }
        public static bool Remove(int val)
        {
            if (!HT.ContainsKey(val)) return false;

            var index = (LinkedList<LinkedListNode<int>>)HT[val]!;
            var firstNode = index.First!.Value;
            Structure.Remove(firstNode);

            index.RemoveFirst();
            if (index.Count == 0)
            {
                HT.Remove(val);
            }
            return true;
        }
    }
}