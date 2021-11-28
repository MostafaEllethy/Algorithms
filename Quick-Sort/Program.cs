using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read random numbers from file
            List<int> numbers = System.IO.File.ReadAllText("Numbers.txt").Split(' ').Select(x => int.Parse(x)).ToList();

            //Call Quick Sort algorithm on numbers then print the sorted list
            foreach (int number in Sort(numbers))
            {
                Console.WriteLine(number);
            }
        }

        static List<int> Sort(List<int> list)
        {
            //If list is equal or less than 1 return it (Recursion base case)
            if (list.Count <= 1)
            {
                return list;
            }

            //Init pivot, Greater than pivot list and Less than pivot list
            int pivot = list[0];
            List<int> gtList = new List<int>();
            List<int> ltList = new List<int>();

            //Loop over the list and compare numbers with pivot
            for (int i = 1; i < list.Count; i++)
            {
                //If number is greater than list append it to the gtList
                if (list[i] > pivot)
                {
                    gtList.Add(list[i]);
                }
                else
                {
                    //Else append it in the lsList
                    ltList.Add(list[i]);
                }
            }
            //Init new list calling Sort on less that pivot list and greater than pivot list. And put the pivot between them
            List<int> sorted = Sort(ltList);
            sorted.Add(pivot);
            sorted.AddRange(Sort(gtList));

            //Return sorted list
            return sorted;

        }
    }
}
