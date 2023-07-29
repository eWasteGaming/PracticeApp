using System;

namespace PracticeApp.Exercises
{
    public class Exercise4
    {
        public static void solve() 
        {

            //A C# program to print the result of the specified operations

            string expression1 = "-1 + 4 * 6";
            double solution1 = -1 + 4 * 6;

            string expression2 = "( 35+ 5 ) % 7";
            double solution2 = (35 + 5) % 7;

            string expression3 = "14 + -4 * 6 / 11";
            double solution3 = 14 + -4 * 6 / 11;

            string expression4 = "2 + 15 / 6 * 1 - 7 % 2";
            double solution4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(expression1 + " = " + solution1);
            Console.WriteLine(expression2 + " = " + solution2);
            Console.WriteLine(expression3 + " = " + solution3);
            Console.WriteLine(expression4 + " = " + solution4);

        }
    }
}
