using System;
using System.Collections.Generic;

namespace textAdventure2
{
    public class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine($"You added {item} to your inventory.");
        }

        public void RemoveItem(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"You removed {item} from your inventory.");
            }
            else
            {
                Console.WriteLine($"You don't have {item} in your inventory.");
            }
        }

        public void ShowInventory()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
            }
            else
            {
                Console.WriteLine("Your inventory contains:");
                foreach (string item in items)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }
    }
}
