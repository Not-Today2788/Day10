using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    Console.Write("*         *");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}