using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read numbers from file
            List<int> numbers = File.ReadAllText("Numbers.txt").Split(' ').Select(x => int.Parse(x)).ToList();

            //New list to carry the sorted elements
            List<int> sortedList = new List<int>();

            //Loop over the list until empty
            while (numbers.Any())
            {
                //Init min and index to first item in the list
                int min = numbers[0], index = 0;

                //Loop over the list
                for (int i = 1; i < numbers.Count; i++)
                {
                    //Compare current number with min recorded one
                    if (numbers[i] < min)
                    {
                        //Save min number and it's index
                        min = numbers[i];
                        index = i;
                    }
                }
                //Add smallest number to the sorted list
                sortedList.Add(min);
                //Remove it from the original list
                numbers.RemoveAt(index);
            }

            //Print sorted list
            foreach (int i in sortedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
