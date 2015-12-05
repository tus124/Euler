using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class PrimesTests
    {
        [TestMethod]
        public void IsPrimeTest()
        {
            Assert.IsTrue(Primes.IsPrime(1) == false);
            Assert.IsTrue(Primes.IsPrime(2) == true);
            Assert.IsTrue(Primes.IsPrime(3) == true);
            Assert.IsTrue(Primes.IsPrime(5) == true);
            Assert.IsTrue(Primes.IsPrime(7) == true);
            Assert.IsTrue(Primes.IsPrime(11) == true);
        }

        [TestMethod]
        public void GetPrimesTest()
        {
            List<int> result = Primes.GetPrimes();
            Assert.IsTrue(result[10000] == 104743);
        }

        [TestMethod]
        public void SumPrimesTest()
        {
            var result = Primes.SumPrimes(2000000);
            Assert.IsTrue(result == 142913828922);
        }
    }
}