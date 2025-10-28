// See https://aka.ms/new-console-template for more information
// to convert input strings from lower to upper and upper to lower case

using System;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Lab 2 ===");
            Console.WriteLine("Program started...\n");

            Console.WriteLine("Enter the string to convert from lower to uppercase: ");
            string input = Console.ReadLine();

            string upper = input.ToUpper();
            Console.WriteLine("The converted output is : " + upper);

            Console.WriteLine("Enter the string to convert from upper to lowercase: ");
            string input2 = Console.ReadLine();

            string lower = input2.ToLower();
            Console.WriteLine("The converted output is : " + lower);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

