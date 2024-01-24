using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write($" *");
                }
                Console.WriteLine();
                n--;
            }
            Console.ReadLine();
        }
    }
}