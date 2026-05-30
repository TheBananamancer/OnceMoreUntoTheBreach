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
            Console.WriteLine("Which way do you go? (north, east, west, south)");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case North:
                    Console.WriteLine("You enter the forest. It is dark and foreboding.");
                    break;
                case East:
                    Console.WriteLine("You approach the lake. The water is crystal clear.");
                    break;
                case West:
                    Console.WriteLine("You walk through the field. The wheat sways gently in the breeze.");
                    break;
                case South:
                    Console.WriteLine("You trudge into the swamp. The air is thick with the smell of decay.");
                    break;
                default:
                    Console.WriteLine("Invalid direction. You remain at the crossroads.");
                    break;
            }
        }

        public static void SecondScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you come across a bridge.");
            Console.WriteLine("A troll stands guard, demanding a toll.");
            Console.WriteLine("Do you pay the toll, or try to cross without paying? (yes, no)");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "yes":
                    Console.WriteLine("You pay the troll, and he lets you pass.");
                    break;
                case "no":
                    Console.WriteLine("You try to sneak past the troll, but he catches you. He attacks!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. The troll is getting impatient.");
                    break;
            }
        }

                public static void ThirdScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you stumble upon a hidden cave.");
            Console.WriteLine("Inside, you see a chest. Do you open it?");
            Console.WriteLine("Do you open the chest? (yes, no)");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "yes":
                    Console.WriteLine("You open the chest and find gold!");
                    break;
                case "no":
                    Console.WriteLine("You decide not to open the chest and leave the cave.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. You hesitate.");
                    break;
            }
        }
    }
}
