namespace TestProject
{
    internal class MenuItemNumberofPaintings : MenuItem
    {

        public static void JustinMain2()
        {
            var vals = new List<int> { 0, 1, 2, 3, 4, 5 };

            Console.WriteLine($"There are {vals.Count} paintings in the list");
        }

        public override bool ExecuteChoice(List<string> painting)
        {
            throw new NotImplementedException();
        }
    }
}
