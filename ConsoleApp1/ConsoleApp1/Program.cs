using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //Input string
        string inputString = "Hello World, this is a sample";

        //Call the ReverseWords method and display the result
        string reversedString = ReverseWords(inputString);
        Console.WriteLine("Original String: " + inputString);
        Console.WriteLine("Reversed String: " + reversedString);
        Console.ReadLine();
    }

    static string ReverseWords(string input)
    {
        //Split
        string[] words = input.Split(' ');

        //Reverse each word
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }

        //Join the reversed words back into a string
        string reversedString = string.Join(" ", words);
        return reversedString;
    }
}

