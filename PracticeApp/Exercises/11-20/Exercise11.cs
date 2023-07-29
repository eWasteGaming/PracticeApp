using System;

namespace PracticeApp.Exercises
{
    public class Exercise11
    {
        public static void solve() 
        {

            //A C# program that takes an age as input and prints "You look younger than [age]"

            string ageAsString;

            Console.Write("Please enter your age: ");
            ageAsString = Console.ReadLine();

            Console.Write("\n");

            Console.WriteLine($"Wow! You look younger than {ageAsString}!");

        }
    }
}
