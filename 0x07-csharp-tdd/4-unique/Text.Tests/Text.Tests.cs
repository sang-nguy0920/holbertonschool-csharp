using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void firstChar()
        {
            string word = "saaaaa";
            int res = Str.UniqueChar(word);
            Assert.AreEqual(0, res);
        }

        [Test]
        public void lastChar()
        {
            string word = "aaaaas";
            int res = Str.UniqueChar(word);
            Assert.AreEqual(5, res);
        }

        [Test]
        public void midChar()
        {
            string word = "aasaa";
            int res = Str.UniqueChar(word);
            Assert.AreEqual(2, res);
        }

        [Test]
        public void noUniqChar()
        {
            string word = "aaaaa";
            int res = Str.UniqueChar(word);
            Assert.AreEqual(-1, res);
        }

        [Test]
        public void emptyChar()
        {
            string word = "";
            int res = Str.UniqueChar(word);
            Assert.AreEqual(-1, res);
        }
    }
}
