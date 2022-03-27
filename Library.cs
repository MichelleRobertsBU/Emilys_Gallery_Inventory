using Emily_s_Gallery_Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace TestProject
{
    public static class Library
    {
        public static int GetNumber(string message = "Insert Number")
        {
            Console.Write($"{message}: ");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("I don't understand, can you please try again.");
                return GetNumber();
            }
        }
    }
}
