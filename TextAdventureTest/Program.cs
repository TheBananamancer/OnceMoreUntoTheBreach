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
        private const string InventoryCommand = "inventory";

        static void Main(string[] args)
        {
            GameTitle();
            string playerName = GetPlayerName();
            Inventory inventory = new Inventory();
            Scenarios.FirstScenario(playerName);

            Console.WriteLine("\nWhat do you do?");
            string action = Console.ReadLine().ToLower();

            if (action == InventoryCommand)
            {
                inventory.ListInventory();
            }

            Scenarios.SecondScenario(playerName);

            Console.WriteLine("\nWhat do you do?");
            action = Console.ReadLine().ToLower();

            if (action == InventoryCommand)
            {
                inventory.ListInventory();
            }

            Scenarios.ThirdScenario(playerName);

            Console.WriteLine("\nWhat do you do?");
            action = Console.ReadLine().ToLower();

            if (action == InventoryCommand)
            {
                inventory.ListInventory();
            }

            Scenarios.FourthScenario(playerName);

            Console.WriteLine("\nWhat do you do?");
            action = Console.ReadLine().ToLower();

            if (action == InventoryCommand)
            {
                inventory.ListInventory();
            }
        }

        static void GameTitle()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Welcome to Text Adventure!");
            Console.WriteLine("-------------------------------------");
        }

        static string GetPlayerName()
        {\r
            Console.WriteLine("What is your name, adventurer?");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name:");
                name = Console.ReadLine();
            }

            Console.WriteLine($"\nWelcome, {name}!");
            return name;
        }

    }
}