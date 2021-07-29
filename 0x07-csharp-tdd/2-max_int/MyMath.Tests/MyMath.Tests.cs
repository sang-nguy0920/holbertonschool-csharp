using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void emptyList()
        {
            List<int> nums = new List<int> {};
            int max = Operations.Max(nums);
            Assert.AreEqual(0, max);
        }

        [Test]
        public void negNum()
        {
            List<int> nums = new List<int> {-3, -7, -10};
            int max = Operations.Max(nums);
            Assert.AreEqual(-3, max);
        }
    }
}
