namespace EmilysArtInventory
{
    abstract class MenuItem
    {
        public string? Choice { get; set; }
        public abstract bool ExecuteChoice(List<string> painting);
    }
}