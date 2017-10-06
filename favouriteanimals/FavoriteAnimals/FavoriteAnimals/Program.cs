using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FavoriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "List:";
            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine("What is your favoritve animal: ");
                input = Console.ReadLine();
            }
            else
            {
                return;
            }
                using (StreamWriter writer = File.AppendText("favourites.txt"))
                {
                    writer.WriteLine(input);
                }
        }
    }
}
