namespace TestProject
{//Add Painting to List
    internal class MenuItemAddNewPainting : MenuItem
    {
        public MenuItemAddNewPainting()
        {
            this.Choice = "Add New Painting";
        }
        public override bool ExecuteChoice(List<string> painting)
        {
            //Insert new painting
            Console.WriteLine("Enter painting name:");
            string input = Console.ReadLine();

            while (String.IsNullOrEmpty(input))
            {
                //If no response
                Console.WriteLine("Please enter another painting name: ");
                input = Console.ReadLine();
            }
            if (!String.IsNullOrEmpty(input))
            {
               
                Console.WriteLine("The painting that was added to the list is: " + " " + input);
                painting.Add(input);
                foreach (var value in painting)
                {
                    //Show new list
                    Console.WriteLine();
                }

                return true;
            }

            Console.ReadLine();
            return true;

        }
    }
}
