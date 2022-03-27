namespace TestProject
{
    internal class MenuItemAddNewPainting : MenuItem
    {
        public MenuItemAddNewPainting()
        {
            this.Choice = "Add New Painting";
        }
        public static void JustinMain()
        {
           
        }

        public override bool ExecuteChoice(List<string> painting)
        {
            Console.WriteLine("Enter painting name:");
            string input = Console.ReadLine();

            while (String.IsNullOrEmpty(input))
            {

                Console.WriteLine("Please enter another painting name: ");
                input = Console.ReadLine();

            }


            if (!String.IsNullOrEmpty(input))
            {
                return true;
            }
            Console.WriteLine("The painting you have entered is: " + " " + input);
            painting.Add(input);
            foreach (var value in painting)
            {
                Console.WriteLine();
                Console.WriteLine("The painting that was added to the list is : " + " " + value);

            }
            Console.ReadLine();
            return true;
        }
    }
}
