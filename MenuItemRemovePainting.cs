namespace TestProject
{
    internal class MenuItemRemovePainting : MenuItem
    {
        public MenuItemRemovePainting()
        {
            this.Choice = "Remove Painting";
        }
        public static void JustinMain()
        {

        }

        public override bool ExecuteChoice(List<string> painting)
        {
            Console.WriteLine("Enter painting to be deleted:");
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
            Console.WriteLine("The painting that will be deleted is: " + " " + input);
            painting.Remove(input);
            foreach (var value in painting)
            {
                Console.WriteLine();
                Console.WriteLine("The painting that was deleted is : " + " " + value);

            }

            Console.ReadLine();
            return true;
        }
    }
}
    
        