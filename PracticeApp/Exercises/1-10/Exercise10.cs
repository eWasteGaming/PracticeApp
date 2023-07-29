using System;

namespace PracticeApp.Exercises
{
    public class Exercise10
    {
        public static void solve() 
        {

            //A C# program that takes three numbers (x,y,z) as input and prints the output of (x+y)*z and x*y + y*z

            string temp;
            double[] nums = new double[3];

            Console.WriteLine("Please enter numbers for x, y, and z (press ENTER after each)");

            for (int i = 0; i < 3; i++)
            {
                temp = Console.ReadLine();
                nums[i] = Convert.ToDouble(temp);
            }

            Console.WriteLine("(x+y)*z = " + ((nums[0] + nums[1]) * nums[2]));
            Console.WriteLine("x*y + y*z = " + (nums[0] * nums[1] + nums[1] * nums[2]));

        }
    }
}
