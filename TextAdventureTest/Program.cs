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

        static int playerHitPoints = 100;

        static void Main(string[] args)
        {\r
            GameTitle();
            string playerName = GetPlayerName();
            Inventory inventory = new Inventory();
            
            PlayScenario(Scenarios.FirstScenario, playerName, inventory);
            PlayScenario(Scenarios.SecondScenario, playerName, inventory);
            PlayScenario(Scenarios.ThirdScenario, playerName, inventory);
            PlayScenario(Scenarios.FourthScenario, playerName, inventory);
        }

        static void GameTitle()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Welcome to Text Adventure!");
            Console.WriteLine("-------------------------------------");
        }

        static string GetPlayerName()
        {
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

        static void PlayScenario(Action<string> scenario, string playerName, Inventory inventory)
        {
            scenario(playerName);
            string action = GetPlayerAction(inventory);
        }

        static string GetPlayerAction(Inventory inventory)
        {
            Console.WriteLine("\nWhat do you do?");
            string action = Console.ReadLine().ToLower();

            if (action == InventoryCommand)
            {
                inventory.ListInventory();
                return GetPlayerAction(inventory); // Ask again after listing inventory
            }
            return action;
        }

    }
}