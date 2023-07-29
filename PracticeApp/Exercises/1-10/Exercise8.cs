using System;

namespace PracticeApp.Exercises
{
    public class Exercise8
    {
        public static void solve() 
        {

            //A C# program that takes a number as input and print its multiplication table.

            string temp;
            int num;

            Console.WriteLine("Please enter a whole number: ");
            temp = Console.ReadLine();
            num = Convert.ToInt32(temp);

            for (int i = 0; i <= 12 ; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

        }
    }
}
