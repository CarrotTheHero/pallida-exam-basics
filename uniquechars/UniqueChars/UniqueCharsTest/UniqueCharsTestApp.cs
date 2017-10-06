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
            string output = "borso";

            Assert.AreEqual(output, uniqueCharsApp.UniqueCharacter("borso"));
        }

        [Test]
        public void SortedWord()
        {
            UniqueCharsApp uniqueCharsApp = new UniqueCharsApp();
            var LettersOrdered = "bors";
            

            Assert.AreEqual(LettersOrdered, uniqueCharsApp.UniqueCharacters("borso"));
        }

        [Test]
        public void WriteThemSeparetly()
        {
            string lastoutput = "";
            //("b", "o", "r", "s") it should look like this. code is not ready for this yet
        }
    }
}
