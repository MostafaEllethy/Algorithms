using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogo_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading list of random numbers (1000 number) from a file
            List<int> nums = File.ReadAllText("numbers.txt").Split(' ').Select(x => int.Parse(x)).ToList();

            //Number of shuffles
            int count = 0;

            //Check if the list is sorted
            while (!Verify(nums))
            {
                //
                nums = Shuffle(nums);
                count++;
            }
            Console.WriteLine($"Counts: {count}");
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        private static List<int> Shuffle(List<int> list)
        {
            Random _rng = new Random();
            for (int n = list.Count; n > 1;)
            {
                int k = _rng.Next(n);
                --n;
                int temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
            return list;
        }


        private static bool Verify(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
