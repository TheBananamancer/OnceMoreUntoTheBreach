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
            Console.WriteLine("Which way do you go? (north/east/west/south)");

            string choice = Console.ReadLine().ToLower();

            if (choice == North)
            {
                Console.WriteLine("You enter the dark forest. It's eerily quiet, and the path ahead is unclear.");
            }
            else if (choice == East)
            {
                Console.WriteLine("You approach the shimmering lake. The water is crystal clear, and you can see fish swimming below.");
            }
            else if (choice == West)
            {
                Console.WriteLine("You walk into the field of wheat. The wind gently blows through the stalks.");
            }
            else if (choice == South)
            {
                Console.WriteLine("You cautiously step into the swamp. The ground is soft and muddy.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You remain at the crossroads.");
            }
        }

        public static void SecondScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you are standing in front of a large, ancient oak tree.");
            Console.WriteLine("You see a winding path leading up the hill and a dark cave entrance nearby.");
            Console.WriteLine("Do you follow the path or enter the cave? (path/cave)");

            string choice = Console.ReadLine().ToLower();
            string Path = "path";
            string Cave = "cave";

            if (choice == Path)
            {
                Console.WriteLine("You start following the winding path up the hill. The view becomes increasingly stunning.");
            }
            else if (choice == Cave)
            {
                Console.WriteLine("You cautiously enter the dark cave. The air is cold and damp.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You remain by the oak tree, unsure of what to do.");");
            }
        }

        public static void ThirdScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you arrive at a bustling town square.");
            Console.WriteLine("You see a merchant selling goods, a group of people gathered around a storyteller, and a sign pointing towards a mysterious tower.");
            Console.WriteLine("Do you visit the merchant, listen to the storyteller, or head to the tower? (merchant/storyteller/tower)");

            string choice = Console.ReadLine().ToLower();
            string Merchant = "merchant";
            string Storyteller = "storyteller";
            string Tower = "tower";

            if (choice == Merchant)
            {
                Console.WriteLine("You approach the merchant and browse their wares. You find a curious item that catches your eye.");
            }
            else if (choice == Storyteller)
            {
                Console.WriteLine("You listen to the storyteller's tale. It's a captivating story filled with adventure and magic.");
            }
            else if (choice == Tower)
            {
                Console.WriteLine("You head towards the mysterious tower. It looms tall and ominous in the distance.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You wander aimlessly in the town square.");
            }
        }

        public static void FourthScenario(string playerName)
        {
            Console.WriteLine($"\n{playerName}, you stand before a rushing river.");
            Console.WriteLine("A rickety bridge spans the river, and a small boat is tied to the bank.");
            Console.WriteLine("Do you cross the bridge or take the boat? (bridge/boat)");

            string choice = Console.ReadLine().ToLower();
            string Bridge = "bridge";
            string Boat = "boat";

            if (choice == Bridge)
            {
                Console.WriteLine("You carefully cross the rickety bridge. It creaks and sways with each step.");
            }
            else if (choice == Boat)
            {
                Console.WriteLine("You untie the small boat and set off down the river. The current is strong.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You remain by the riverbank, contemplating your next move.");
            }
        }
    }
}