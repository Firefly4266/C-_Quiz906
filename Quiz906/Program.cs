using System;

/* 2)   Write a simple structure that contains 2 integer variables.Create a
        class that will use those two variables by initializing them then
        summing them. */

namespace Quiz906
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum tree = new Sum();
            Console.WriteLine(tree.GetSum(3, 4));
        }
        public struct Sum
        {
            public int x;
            public int y;

            //public Sum()
            //{
            //}
            public int GetSum(int x, int y)
            {
                return x + y;
            }
        }
    }
}

