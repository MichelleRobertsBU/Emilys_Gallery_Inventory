using Emily_s_Gallery_Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace Emily_s_Gallery_Inventory
{
    abstract class MenuItem
    {
        public string? Choice { get; set; }
        public abstract bool ExecuteChoice();
    }
}