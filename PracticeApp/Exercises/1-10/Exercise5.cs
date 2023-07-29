using System;

namespace PracticeApp.Exercises
{
    public class Exercise5
    {
        public static void solve() 
        {

            //A C# program to swap two numbers. 

            int num1 = 6;
            int num2 = 19;
            int temp;

            Console.WriteLine($"The first number is {num1}, the second number is {num2}");
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After swapping, the first number is {num1} and the second is {num2}");

        }
    }
}
