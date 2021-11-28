using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Program
    {
        static bool Validate(int target)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in list)
            {
                if (i == target)
                {
                    return true;
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
