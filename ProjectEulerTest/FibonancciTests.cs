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

        [TestMethod]
        public void LargeFibonancciTest()
        {
            Assert.IsTrue(Fibonancci.LargeFibonancci(6) == "720");
            Assert.IsTrue(Fibonancci.LargeFibonancci(7) == "5040");
            Assert.IsTrue(Fibonancci.LargeFibonancci(100) == "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000");

            Assert.IsTrue(Fibonancci.LargeFibonancciDigitSum(10) == 27);
            Assert.IsTrue(Fibonancci.LargeFibonancciDigitSum(100) == 648);
        }
    }
}