using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargeNumbers.Tests
{
    [TestClass]
    public class LargeSumTests
    {
        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(LargeSum.Add("999", "99") == "1098");
            Assert.IsTrue(LargeSum.Add("999", "999") == "1998");
        }
    }
}