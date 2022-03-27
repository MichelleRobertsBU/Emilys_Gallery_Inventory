namespace TestProject
{
    internal class MenuItemExit : MenuItem
    {
        public MenuItemExit()
        {
            this.Choice = "Exit";
        }

        public override bool ExecuteChoice(List<string> painting)
        {
            return false;
        }
    }
}
