using System;

namespace PracticeApp.Exercises
{
    public class Exercise6
    {
        public static void solve() 
        {

            //A C# program to print the output of multiplication of three numbers which will be entered by the user. 

            double[] nums = new double[3];
            string temp;

            Console.WriteLine("Please input 3 numbers (press ENTER after each one)");
            for (int i = 0; i < nums.Length; i++)
            {
                temp = Console.ReadLine();
                nums[i] = Convert.ToDouble(temp);
            }

            double product = nums[0] * nums[1] * nums[2];

            Console.WriteLine("The multiplication equation is as follows:");
            Console.WriteLine($"{nums[0]} * {nums[1]} * {nums[2]} = {product}");

        }
    }
}
