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

            int n = 134, last_digit, sum = 0;
            while (n > 0)
            {
                last_digit = n % 10;
                n = n / 10;
                sum = sum + last_digit;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
