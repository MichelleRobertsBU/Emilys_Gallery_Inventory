namespace TestProject
{//Remove Painting from List
    internal class MenuItemRemovePainting : MenuItem
    {
        public MenuItemRemovePainting()
        {
            this.Choice = "Remove Painting";
        }
        public override bool ExecuteChoice(List<string> painting)
        {
            //Get painting to be deleted
            Console.WriteLine("Enter painting to be deleted:");
            string input = Console.ReadLine();

            while (String.IsNullOrEmpty(input))
            {
                //If no response
                Console.WriteLine("Please enter another painting name: ");
                input = Console.ReadLine();

            }
            if (!String.IsNullOrEmpty(input))
            {
                Console.WriteLine("The painting that was deleted is: " + " " + input);
                painting.Remove(input);
                foreach (var value in painting)
                {//Show new list
                    Console.WriteLine();
                }
                return true;
            }
            Console.ReadLine();
            return true;
        }
    }
}

