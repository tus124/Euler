using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class MultiplesTests
    {
        [TestMethod]
        public void FindMulti3or5Test()
        {
            int result = Multiples.FindMulti3or5(1000);
            Assert.IsTrue(result == 233168, "Multiple of 3 or 5 test results");
        }
    }
}