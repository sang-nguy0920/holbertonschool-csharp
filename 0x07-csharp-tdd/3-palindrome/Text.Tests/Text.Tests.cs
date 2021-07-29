using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Reggie()
        {
            string pali = "poop";
            bool res = Str.IsPalindrome(pali);
            Assert.AreEqual(true, res);
        }

        [Test]
        public void lowerPali()
        {
            string pali = "A man, a plan, a canal: Panama.";
            bool res = Str.IsPalindrome(pali);
            Assert.AreEqual(true, res);
        }

        [Test]
        public void empty()
        {
            string pali = "";
            bool res = Str.IsPalindrome(pali);
            Assert.AreEqual(true, res);
        }
    }
}