namespace EmilysArtInventory
{//Get Number of Paintings in List
    internal class MenuItemNumberofPaintings : MenuItem
    {
        public MenuItemNumberofPaintings()
        {
            this.Choice = "Number of Paintings";
        }

        public override bool ExecuteChoice(List<string> painting)
        {
            var totalpainting = painting.Count();

            Console.WriteLine($"There are {painting.Count()} paintings in the list.");
            Console.WriteLine();
            return true;
        }
    }

}
