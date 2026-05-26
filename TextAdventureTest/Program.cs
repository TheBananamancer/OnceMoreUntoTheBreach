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
            Scenarios.FirstScenario(playerName, inventory);
            Scenarios.SecondScenario(playerName, inventory);
            Scenarios.ThirdScenario(playerName, inventory);
            Scenarios.FourthScenario(playerName, inventory);
        }

        static void GameTitle()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("|        Text Adventure Game         |");
            Console.WriteLine("======================================\n");
        }

        static string GetPlayerName()
        {
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            return playerName;
        }
    }

    class Inventory
    {
        public List<string> Items { get; set; } = new List<string>();

        public void AddItem(string item)
        {
            Items.Add(item);
            Console.WriteLine($"You added {item} to your inventory.");
        }

        public void RemoveItem(string item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                Console.WriteLine($"You removed {item} from your inventory.");
            }
            else
            {
                Console.WriteLine($"You don't have {item} in your inventory.");
            }
        }

        public void ShowInventory()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
            }
            else
            {
                Console.WriteLine("Inventory:");
                foreach (string item in Items)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }
    }
}