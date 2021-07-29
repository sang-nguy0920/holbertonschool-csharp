using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>Public Tests class.</summary>
    public class Tests
    {
        [Test]
        public void regular()
        {
            int[,] matrix = new int[,] {{2, 3}, {4, 5}, {6, 7}};
            int num = 1;
            int[,] res = Matrix.Divide(matrix, num);
            Assert.AreEqual(matrix, res);
        }

        [Test]
        public void zerodivide()
        {
            int[,] matrix = new int[,] {{2, 3}, {4, 5}, {6, 7}};
            int num = 0;
            int[,] res = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, res);
        }
    }
}
