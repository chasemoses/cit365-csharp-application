using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            GetUserNameAndLocation();
            Console.WriteLine();

            ChristmasCountdown(date);
            Console.WriteLine();

            GlazerApp.RunExample();
            Console.ReadKey();
        }


        private static void GetUserNameAndLocation()
        {
            Person person = new Person();

            // Prompt user for name and store it in the "Name" field.
            Console.WriteLine("What is your name?");
            person.Name = Console.ReadLine();

            // Do Response
            Console.WriteLine($"Hi, {person.Name}! Where are you from?");

            // Record response in Location
            person.Location = Console.ReadLine();

            // Third Response
            Console.WriteLine($"I have never been to {person.Location}. I bet it is nice.");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


        }

        private static void ChristmasCountdown(DateTime date)
        {
            // Display current date.
            Console.WriteLine($"Today's date is: {date.ToShortDateString()}");

            // Calculate number of days until Christmas
            DateTime christmas = new DateTime(2022, 12, 25);

            TimeSpan daysUntilChristmas = christmas - date;

            // Display days until Christmas to user.
            Console.WriteLine($"There are {daysUntilChristmas.Days} days until Christmas!");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
