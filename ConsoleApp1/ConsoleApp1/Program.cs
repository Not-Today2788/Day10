using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 1, 8, 9, 5 };

            Console.WriteLine("\nUnique elements in the array: ");

            //I am using HashSet to track unique elements
            HashSet<int> uniqueElements = new HashSet<int>();

            foreach (int num in array)
            {
                //Add the element to the HashSet
                //HashSet will automatically discard duplicates
                uniqueElements.Add(num);
            }

            //Print 
            foreach (int uniqueElement in uniqueElements)
            {
                Console.Write(uniqueElement + " ");
            }
        }
    }
}
