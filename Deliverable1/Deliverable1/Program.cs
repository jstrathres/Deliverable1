using System;

public class Program
{
    public static void Main()
    {
        bool restart = true;

        while (restart)
        {
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            string userInput = Console.ReadLine();

            int totalPeople = int.Parse(userInput);
            int numberOfSlices = 28;
            int numberOfPB = 32;
            int numberOfJ = 48;
            double slices = 2 * totalPeople;
            double tablespoons = 2 * totalPeople;
            double teaspoons = 4 * totalPeople;

            Console.WriteLine("You will need " + slices + " slices of bread.");
            Console.WriteLine("You will need " + tablespoons + " tablespoons of peanut butter.");
            Console.WriteLine("You will need " + teaspoons + " teaspoons of jelly.");

            double loaves = Math.Ceiling(slices / numberOfSlices);
            double pbJars = Math.Ceiling(tablespoons / numberOfPB);
            double jJars = Math.Ceiling(teaspoons / numberOfJ);

            Console.WriteLine("You will need " + loaves + " loaves of bread.");
            Console.WriteLine("You will need " + pbJars + " jars of peanut butter.");
            Console.WriteLine("You will need " + jJars + " jars of jelly.");
            Console.WriteLine("Would you like to start the program over?");
            userInput = Console.ReadLine();

            if (userInput == "y" || userInput == "yes")
            {
                restart = true;
            }
            else
            {
                restart = false;
                Console.WriteLine("Goodbye.");
            }
        }
    }
}