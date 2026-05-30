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
            GameTitle();
            string playerName = GetPlayerName();
            Inventory inventory = new Inventory();
            Scenarios.FirstScenario(playerName);
            Scenarios.SecondScenario(playerName);
        }

        static string GetPlayerName()
        {
            Console.WriteLine("What is your name, adventurer?");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("That is not a valid name.");
                return GetPlayerName();
            }
            return name;
        }

        static void GameTitle()
        {
            Console.WriteLine("Welcome to the Text Adventure Game!");
            Console.WriteLine("----------------------------------\n");
        }
    }
}
