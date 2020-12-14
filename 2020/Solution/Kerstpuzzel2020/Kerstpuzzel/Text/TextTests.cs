using NUnit.Framework;

namespace Kerstpuzzel.Text
{
    [TestFixture]
    public class TextTests
    {

        [Test]
        public void Vowel_found()
        {
            Assert.IsTrue(Text.IsVowel("a"));
            Assert.IsTrue(Text.IsVowel("A"));
            Assert.IsTrue(Text.IsVowel("e"));
            Assert.IsTrue(Text.IsVowel("E"));
            Assert.IsTrue(Text.IsVowel("i"));
            Assert.IsTrue(Text.IsVowel("I"));
            Assert.IsTrue(Text.IsVowel("o"));
            Assert.IsTrue(Text.IsVowel("O"));
            Assert.IsTrue(Text.IsVowel("u"));
            Assert.IsTrue(Text.IsVowel("U"));

        }

        [Test]
        public void Vowel_not_found()
        {
            Assert.IsFalse(Text.IsVowel("k"));
            Assert.IsFalse(Text.IsVowel("L"));
        }

        [Test]
        public void Contains_Vowels()
        {
            Assert.IsTrue(Text.ContainsVowel("bakje"));
        }

        [Test]
        public void Does_not_Contain_Vowels()
        {
            Assert.IsFalse(Text.ContainsVowel("bkjl"));
        }

        [Test]
        public void Contains_Consonant()
        {
            Assert.IsTrue(Text.ContainsConsonant("bakje"));
            Assert.IsTrue(Text.ValidDoubleConsonant("bakje"));
            Assert.IsTrue(Text.CouldBeADutchWord("bakje"));
        }

        [Test]
        public void Does_not_Contain_Consonant()
        {
            Assert.IsFalse(Text.ContainsConsonant("aui"));
        }

        [Test]
        public void Invalid_doube_consonant_at_start()
        {
            Assert.IsFalse(Text.ValidDoubleConsonant("bbakje"));
        }

        [Test]
        public void Valid_doube_consonant_at_start()
        {
            Assert.IsTrue(Text.ValidDoubleConsonant("brakje"));
        }

        [Test]
        [TestCase("slav")]
        [TestCase("slaz")]
        [TestCase("slah")]
        [TestCase("slaj")]
        [TestCase("slaw")]
        public void Invalid_Dutch_word(string word)
        {
            Assert.IsFalse(Text.CouldBeADutchWord(word));
        }

        [Test]
        public void Valid_Dutch_word()
        {
            Assert.IsTrue(Text.CouldBeADutchWord("Nieuw"));
        }
    }
}
