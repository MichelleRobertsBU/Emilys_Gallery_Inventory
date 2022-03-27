using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emily_s_Gallery_Inventory;
using TestProject;

//EmilysArtInventory

namespace Emily_s_Gallery_Inventory
{
    class Program
    {
        public void Main(string[] args)
        {
            var painting = new List<string> { "Kids", "Mom" };
            Console.WriteLine(string.Join(", ", painting));
        } 

    }

    class MainClass
    {
        static List<MenuItem> menuItems = new List<MenuItem>();

        public static void Main()
        {
            menuItems.Add(new MenuItemAddNewPainting());
            menuItems.Add(new MenuItemChoosePaintingtoUpdate());
            menuItems.Add(new MenuItemRemovePainting());
            menuItems.Add(new MenuItemExit());

            var keepGoing = true;
            while (keepGoing)
            {
                keepGoing = MainMenu();
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
            Console.WriteLine("Program exited");
        }

              public static bool MainMenu()
        {
            // show user a menu
            Console.WriteLine("Main Menu:");

            for (int i = 0; i < menuItems.Count; i++)
            {
                MenuItem item = menuItems[i];
                Console.WriteLine($"{i}. {item.Choice}");
            }

            Console.Write("Enter your choice: ");
            // ask for their choice
            int userChoice = Library.GetNumber();

            Console.WriteLine("");

            if (userChoice < menuItems.Count)
            {
                return menuItems[userChoice].ExecuteChoice();
            }
            else
            {
                Console.WriteLine($"You have input the choice '{userChoice}'.");
                Console.WriteLine("That isn't valid, try again.");
                return true;
            }
        }
    }
}

