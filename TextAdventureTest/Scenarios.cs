using System;

namespace textAdventure2
{
    public class Scenarios
    {
        private const string North = "north";
        private const string East = "east";
        private const string West = "west";
        private const string South = "south";

        public static void FirstScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you find yourself at a crossroads.");
            Console.WriteLine("A dark forest lies to the north, a shimmering lake to the east, a field of wheat to the west, and a swamp to the south.");
            Console.WriteLine("Which direction do you choose? (north, east, west, south)");

            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case North:
                    Console.WriteLine("You enter the dark forest...");
                    break;
                case East:
                    Console.WriteLine("You approach the shimmering lake...");
                    break;
                case West:
                    Console.WriteLine("You walk into the field of wheat...");
                    break;
                case South:
                    Console.WriteLine("You cautiously enter the swamp...");
                    break;
                default:
                    Console.WriteLine("Invalid direction. You remain at the crossroads.");
                    break;
            }
        }

        public static void SecondScenario(string playerName, Inventory inventory)
        {
            Console.WriteLine($"\n{playerName}, you are walking along a path when you see a small cottage.");
            Console.WriteLine("Do you enter the cottage? (yes/no)");

            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "yes":
                    Console.WriteLine("You enter the cottage. It is dark and dusty.");
                    Console.WriteLine("You find a rusty sword! You add it to your inventory.");
                    inventory.AddItem("Rusty Sword");
                    break;
                case "no":
                    Console.WriteLine("You continue along the path.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. You remain on the path.");
                    break;
            }
        }
    }
}