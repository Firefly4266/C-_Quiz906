using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3)	Write a program that contains two structures.One for an employee and
        one for their birthdate.Then write a class that will use the structs to
        gather data for two employees stored in an array.Print the data out on
        the screen in a single sentence.*/

namespace Quiz906
{
    class Program
    {
        struct Employees
        {
            public string name;
        }
        struct Birthdays
        {
            public int day, year;
            public string month;
        }

        static void Main(string[] args)
        {
            Employees[] staff = new Employees[2];
            Birthdays newStaff = new Birthdays();
            for (int i = 0; i < staff.Length; i++)
            {
                Console.Write("Please enter your NAME: ");
                var userName = Console.ReadLine();
                staff[i].name = userName;
                Console.Write("Please enter your birth YEAR: ");
                var birthYear = Console.ReadLine();
                newStaff.year = int.Parse(birthYear);
                Console.Write("Please enter your birth MONTH: ");
                var birthMonth = Console.ReadLine();
                newStaff.month = birthMonth;
                Console.Write("Please enter your birth DATE: ");
                var dayOfBirth = Console.ReadLine();
                newStaff.day = int.Parse(dayOfBirth);
                Console.WriteLine("Employee: {0} Birthday: {1} {2}, {3}", staff[i], newStaff.year, newStaff.month, newStaff.day);
            }
        }
    }
}
