using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Binary_Search
{
    internal class Program
    {
        static bool DoThings(List<int> list, int target)
        {
            int listCount = list.Count;
            int midpoint = listCount / 2;
            if (listCount > 0)
            {
                if (list[midpoint] == target)
                {
                    return true;
                }
                else if (list[midpoint] > target)
                {
                    return DoThings(list.Take(midpoint).ToList(), target);
                }
                else
                {
                    return DoThings(list.Skip(midpoint + 1).ToList(), target);
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine(DoThings(list, 7));
        }
    }
}
