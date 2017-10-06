using System;
using System.IO;

namespace FavoriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            while (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine("What is your favoritve animal: ");
                input = Console.ReadLine();

                using (StreamWriter writer = File.AppendText("favourites.txt"))
                {
                    writer.WriteLine(input);
                }
            }                
        }
    }
}
