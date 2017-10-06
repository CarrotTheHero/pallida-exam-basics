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
            Console.WriteLine("Press G to start: ");
            string animal = Console.ReadLine();
            if (!string.IsNullOrEmpty(animal))
            {
                Console.WriteLine("Write in your favorite animals: ");
                animal = Console.ReadLine();
                string[] animals = { animal };
                File.WriteAllLines("./favourites.txt", animals);
            }
            Console.ReadLine();
        }
    }
}
