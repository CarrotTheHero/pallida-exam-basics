using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UniqueChars;

namespace UniqueCharsTest
{
    [TestFixture]
    public class UniqueCharsTestApp
    {
        [Test]
        public void ListHasElements()
        {
            UniqueCharsApp uniqueCharsApp = new UniqueCharsApp();
            var LetterByLetter = new List<char>()
            {
                {'b'},
                {'o'},
                {'r'},
                {'s'},
                {'o'},
            };

            Assert.AreEqual(LetterByLetter, uniqueCharsApp.UniqueCharacters("borso"));
        }

        [Test]
        public void SortedList()
        {
            UniqueCharsApp uniqueCharsApp = new UniqueCharsApp();
            var LettersWithoutDouble = new List<char>()
            {
                {'b'},
                {'o'},
                {'o'},
                {'r'},
                {'s'},
            };

            Assert.AreEqual(LettersWithoutDouble, uniqueCharsApp.UniqueCharacters("borso"));
        }
    }
}
