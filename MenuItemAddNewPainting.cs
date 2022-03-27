using Emily_s_Gallery_Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class MenuItemAddNewPainting : MenuItem
    {
        public static void Main()
        {
            List<string> painting = new List<string>();      
            Console.WriteLine("Enter painting name:");
            string input = Console.ReadLine();
          
            while (String.IsNullOrEmpty(input))
            {

                Console.WriteLine("Please enter another painting name: ");
                input = Console.ReadLine();

            }


            if (!String.IsNullOrEmpty(input))
            {
                return;
            }
            Console.WriteLine("The painting you have entered is: " + " " + input);
            painting.Add(input);
            foreach (var value in painting)
            {
                Console.WriteLine();
                Console.WriteLine("The painting that was added to the list is : " + " " + value);

            }
            Console.ReadLine();
        }

        public override bool ExecuteChoice()
        {
            throw new NotImplementedException();
        }
    }
}
