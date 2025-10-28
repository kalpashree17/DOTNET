// See https://aka.ms/new-console-template for more information
//program that exchanges the first and last characters of an input string
using System;


namespace Lab1
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("=== OOP Lab 1 ===");
            Console.WriteLine("Program started...\n");
            Console.Write("Enter the test string you want to exchange first and last character : ");
            string entervalue = Console.ReadLine();
            int length = entervalue.Length;
            Console.WriteLine("The length of the string is: " + length);

            char[] chars = entervalue.ToCharArray();

            char firstchar = entervalue[0];
            char lastchar = entervalue[length - 1];

            char temp = chars[0];
            chars[0] = chars[length - 1];
            chars[length-1] = temp;

            string final = new string(chars);

            Console.WriteLine("the converted string is  is " + final);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
