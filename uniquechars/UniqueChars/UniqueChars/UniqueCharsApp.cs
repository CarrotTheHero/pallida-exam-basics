using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class UniqueCharsApp
    {
        public string UniqueCharacters(string input)
        {
            var CharsWithoutDouble = new List<char>();

            foreach (char letter in input)
            {
                CharsWithoutDouble.Add(letter);
                CharsWithoutDouble.Sort();
            }
            // no input return, i want to return the list elements....
            return input;
        }
    }
}
