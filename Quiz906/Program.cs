using System;


/* 4)	Write a program that will accept a sentence from a user.Return to the
        user the number of vowels and consonants within that string.  Be sure to
        account for capitalization within the sentence and exclude all
        punctuation from the counts.*/

namespace Quiz906
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type out any sentence: ");
            string input = Console.ReadLine().ToLower();
            int con = 0;
            int vow = 0;

            foreach (char i in input)
            {

                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    vow++;
                }
                else if (!char.IsLetter(i))
                {
                }
                else
                    con++;
            }
                Console.WriteLine("There were {0} vowels and {1} constanents in your string.", vow, con);
                int total = con + vow;
                Console.WriteLine(total);
        }
    }
}
