using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static bool Validate(int target)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int first = 0, last = list.Count - 1;
            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (list[mid] == target)
                {
                    return true;
                }
                else if (list[mid] > target)
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Validate(7));
        }
    }
}
