using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
  

    class Program
    {
        // List to store items
        static List<string> itemForStudents = new List<string>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1- Add\n2- Remove\n3- List\n4- Sort\n5- Update\n6- Exit\nChoose an option:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItem();
                        break;
                    case "2":
                        RemoveItem();
                        break;
                    case "3":
                        ListItems();
                        break;
                    case "4":
                        SortItems();
                        break;
                    case "5":
                        UpdateItem();
                        break;

                    case "6":
                        
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        // Function to add an item to the list
        static void AddItem()
        {
            Console.Write("Enter the item to add: ");
            string item = Console.ReadLine();
            itemForStudents.Add(item);
            Console.WriteLine($"'{item}' has been added to the list.");
        }

        static void UpdateItem()
        {
            
            string item = itemForStudents[0];
            itemForStudents[0]="atilim";
            Console.WriteLine($"'{item}' has been updated with atilim.");
        }

        // Function to remove an item from the list
        static void RemoveItem()
        {
            Console.Write("Enter the item to remove: ");
            string item = Console.ReadLine();
            if (itemForStudents.Remove(item))
                Console.WriteLine($"'{item}' has been removed from the list.");
            else
                Console.WriteLine($"'{item}' was not found in the list.");
        }

        // Function to list all items
        static void ListItems()
        {
            Console.WriteLine("\nList Contents:");
            foreach (var item in itemForStudents)
            {
                Console.WriteLine("- " + item);
            }
        }

        // Function to sort the list alphabetically
        static void SortItems()
        {
            itemForStudents.Sort();
            Console.WriteLine("The list has been sorted.");
            ListItems();
        }
    }

}
