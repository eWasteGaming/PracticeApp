using System;

namespace PracticeApp.Exercises
{
    public class Exercise7
    {
        public static void solve() 
        {

            /*A C# program to print on screen the output of adding, subtracting, multiplying, 
            dividing, and modulo of two numbers which will be entered by the user. */

            string temp;
            double num1;
            double num2;

            Console.WriteLine("Please input first number: ");
            temp = Console.ReadLine();
            num1 = Convert.ToDouble(temp);
            
            Console.WriteLine("Please input second number: ");
            temp = Console.ReadLine();
            num2 = Convert.ToDouble(temp);

            Console.Write("\n");

            string sumEquation = $"{num1} + {num2} = {num1 + num2}";
            string subEquation = $"{num1} - {num2} = {num1 - num2}";
            string multEquation = $"{num1} * {num2} = {num1 * num2}";
            string divEquation = $"{num1} / {num2} = {num1 / num2}";
            string modEquation = $"{num1} mod {num2} = {num1 % num2}";

            Console.WriteLine(sumEquation);
            Console.WriteLine(subEquation);
            Console.WriteLine(multEquation);
            Console.WriteLine(divEquation);
            Console.WriteLine(modEquation);

        }
    }
}
