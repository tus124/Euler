using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargeNumbers.Tests
{
    [TestClass]
    public class LargeMultiplyTests
    {
        [TestMethod]
        public void MultiplyTest()
        {
            Assert.IsTrue(LargeMultiply.Multiply("9999", "999") == (9999 * 999).ToString());

            Assert.IsTrue(LargeMultiply.Multiply("9999", "999") == LargeMultiply.Multiply("999", "9999"));

            Assert.IsTrue(LargeMultiply.Multiply("987654321", "999") == (986666666679).ToString());

            Assert.IsTrue(LargeMultiply.Multiply("987654321", "987654321") == (975461057789971041).ToString());
            
        }
    }
}