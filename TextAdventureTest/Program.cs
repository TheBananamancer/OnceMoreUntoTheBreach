using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textAdventure2
{
    class Program
    {
        private const string North = "north";
        private const string East = "east";
        private const string West = "west";
        private const string South = "south";
        private const string Yes = "yes";
        private const string No = "no";

        static void Main(string[] args)
        {
            gameTitle();
            string playerName = GetPlayerName();
            Scenarios.FirstScenario(playerName);
            Scenarios.SecondScenario(playerName);
            Scenarios.ThirdScenario(playerName);
            Scenarios.FourthScenario(playerName);

            Console.WriteLine("\nThanks for playing!");
        }

        static void gameTitle()
        {
            Console.WriteLine("Welcome to the Text Adventure Game!");
            Console.WriteLine("----------------------------------");
        }

        static string GetPlayerName()
        {
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            while (string.IsNullOrEmpty(playerName))
            {
                Console.WriteLine("Name cannot be empty. Please enter your name:");
                playerName = Console.ReadLine();
            }

            return playerName;
        }


    }
}