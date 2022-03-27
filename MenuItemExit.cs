using Emily_s_Gallery_Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace TestProject
{
    internal class MenuItemExit : MenuItem
    {
        public MenuItemExit()
        {
            this.Choice = "Exit";
        }

        public override bool ExecuteChoice()
        {
            return false;
        }
    }
}
