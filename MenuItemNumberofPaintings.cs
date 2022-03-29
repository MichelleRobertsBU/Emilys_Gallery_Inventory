namespace TestProject
{
    internal class MenuItemNumberofPaintings : MenuItem
    {
        public MenuItemNumberofPaintings()
        {
            this.Choice = "Number of Paintings";
        }

        public static void NumberMain()
        {
           
        }
        public override bool ExecuteChoice(List<string> painting)
        {
        var vals = new List<int> { 0, 1, 2, 3, 4, 5 };

        Console.WriteLine($"There are {vals.Count} paintings in the list");
            return true;
        }
    }
}
