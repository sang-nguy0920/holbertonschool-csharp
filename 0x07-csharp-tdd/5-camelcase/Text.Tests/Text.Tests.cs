using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void one()
        {
            string s = "this";
            int count = Str.CamelCase(s);
            Assert.AreEqual(1, count);
        }

        [Test]
        public void two()
        {
            string s = "this Is";
            int count = Str.CamelCase(s);
            Assert.AreEqual(2, count);
        }

        [Test]
        public void multiple()
        {
            string s = "this Is Dumb";
            int count = Str.CamelCase(s);
            Assert.AreEqual(3, count);
        }

        [Test]
        public void empty()
        {
            string s = "";
            int count = Str.CamelCase(s);
            Assert.AreEqual(0, count);
        }
    }
}