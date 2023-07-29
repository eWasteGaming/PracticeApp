
namespace PracticeApp
{
    public class MovieList
    {
        public static void Run()
        {

            string input;
            List<string> movieNames = new List<string>();

            Console.WriteLine("Please enter a movie name, or type exit to list movies and end program.");
            input = Console.ReadLine();

            while (input.ToUpper() != "EXIT")
            {
                movieNames.Add(input);
                Console.WriteLine("Please enter a movie name, or type exit to list movies and end program.");
                input = Console.ReadLine();
            }

            Console.WriteLine("\nListing movie names:");

            foreach (string movie in movieNames)
            {
                Console.WriteLine(movie);
            }

        }
    }
}
