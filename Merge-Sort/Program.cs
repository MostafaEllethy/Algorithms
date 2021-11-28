using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    internal class Program
    {
        static List<int> Sort(List<int> list)
        {
            int listCount = list.Count;
            if (listCount <= 1)
            {
                return list;
            }
            int mid = listCount / 2;
            List<int> leftList = Sort(list.GetRange(0, mid));
            List<int> rightList = Sort(list.GetRange(mid, list.Count - mid));
            int leftIndex = 0;
            int rightIndex = 0;
            List<int> sorted = new List<int>();
            while ((leftIndex < leftList.Count) && (rightIndex < rightList.Count))
            {
                if (leftList[leftIndex] < rightList[rightIndex])
                {
                    sorted.Add(leftList[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    sorted.Add(rightList[rightIndex]);
                    rightIndex++;
                }
            }
            while (leftIndex < leftList.Count)
            {
                sorted.Add(leftList[leftIndex]);
                leftIndex++;
            }
            while (rightIndex < rightList.Count)
            {
                sorted.Add(rightList[rightIndex]);
                rightIndex++;
            }
            return sorted;
        }
        static void Main(string[] args)
        {
            foreach (int i in Sort(new List<int> { 99, 80, 1, 57, 12, 3, -7, 42, 8, 7, 1, 7, 50, 0 }))
            {
                Console.WriteLine(i);
            }
        }
    }
}
