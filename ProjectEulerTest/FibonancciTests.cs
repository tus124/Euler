using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class FibonancciTests
    {
        [TestMethod]
        public void FindFibEvenSumTest()
        {
            long result = Fibonancci.FindFibEvenSum();
            Assert.IsTrue(result == 798, "Sum of the even-valued fibonacci sequence");
        }
    }
}