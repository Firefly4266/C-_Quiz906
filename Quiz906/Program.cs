using System;


/* 1)	Write a program that will ask the user to supply a sentence. Return that
        sentence back to the user with each character separated by a space. */

namespace Quiz906
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type out any sentence: ");
            string input = Console.ReadLine();
            foreach (var i in input)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
