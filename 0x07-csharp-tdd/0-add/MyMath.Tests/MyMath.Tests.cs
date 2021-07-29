using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Public Tests class.</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int sum = Operations.Add(5, 4);
            Assert.AreEqual(sum, 9);
        }
    }
}
