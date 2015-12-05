using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class SumOfTriangleTests
    {
        [TestMethod]
        public void MaxPathSumTest()
        {
            int[] triangle = {
                3,
                7, 4,
                2, 4, 6,
                8, 5, 9, 3
            };

            int result = SumOfTriangle.MaxPathSum(triangle);
            Assert.IsTrue(result == 10);
        }
    }
}