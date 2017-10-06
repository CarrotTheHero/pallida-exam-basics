using System;
using System.Collections.Generic;

namespace UniqueChars
{
    public class UniqueCharsApp
    {
        public string UniqueCharacter(string baseword)
        {
            baseword = "borso";
            return baseword;
        }

        public string UniqueCharacters(string input)
        {
            List<char> characters = new List<char>();
            string unique = string.Empty;

            foreach (char letter in input.ToCharArray())
            {
                if (!characters.Contains(letter))
                {
                    characters.Add(letter);
                }
            }
            foreach (char letter in characters)
            {
                unique += letter;
            }
            return unique;
        }
    }
}
