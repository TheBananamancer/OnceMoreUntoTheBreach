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
        }

        static string GetPlayerName()
        {
            Console.WriteLine("\nWhat is your name, adventurer?");
            string playerName = Console.ReadLine();

            while (string.IsNullOrEmpty(playerName))
            {
                Console.WriteLine("Please enter a valid name:");
                playerName = Console.ReadLine();
            }

            return playerName;
        }

        static void GameTitle()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("          Text Adventure Game           ");
            Console.WriteLine("========================================");
        }
    }
}
