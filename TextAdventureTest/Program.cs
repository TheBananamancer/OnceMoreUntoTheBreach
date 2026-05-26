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
            Scenarios.FirstScenario(playerName);
            Scenarios.SecondScenario(playerName);
            Scenarios.ThirdScenario(playerName);
            Scenarios.FourthScenario(playerName);
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
}