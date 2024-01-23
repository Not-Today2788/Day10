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
            //int[] num = { 1, 2, 3, 4, 5, 4, 4, 5, 3, 7, 5, 6, 4, 3, 3, 0, 6, 6, 5, 8, 9, 4, 6, 8 };
            //int[] numcheck = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //int one=0, two=0, three = 0, four = 0, five = 0, six = 0,x seven = 0, eight = 0, nine = 0,zero=0;

                Console.WriteLine("Input: ");
                string userinput = Console.ReadLine();

                char[] arr2 = userinput.ToCharArray();

                Console.WriteLine("Character Array: ");

                foreach (char c in arr2)
                {
                    Console.Write(c + " ");
                }

                Array.Reverse(arr2);

                Console.WriteLine("\nReversed Array: ");

                foreach (char c in arr2)
                { Console.Write(c + " "); }

                Console.ReadLine();
            
            Console.ReadLine();
        }
    }
}
