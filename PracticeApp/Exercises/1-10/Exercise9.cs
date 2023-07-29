using System;

namespace PracticeApp.Exercises
{
    public class Exercise9
    {
        public static void solve() 
        {

            //A C# program that takes numbers as input to calculate and print the average.

            List<double> nums = new List<double>();
            double total = 0;
            string temp;

            Console.WriteLine("Please enter a number, or type \"done\" to see the average");
            temp = Console.ReadLine();

            while (temp.ToUpper() != "DONE")
            {
                nums.Add(Convert.ToDouble(temp));
                total += Convert.ToDouble(temp);
                Console.WriteLine("Please enter a number, or type \"done\" to see the average");
                temp = Console.ReadLine();
            }

            Console.Write("\n");

            Console.WriteLine("The average of your numbers is " + (total / nums.Count));
        }
    }
}
