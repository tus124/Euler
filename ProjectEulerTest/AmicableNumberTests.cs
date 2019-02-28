using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class AmicableNumberTests
    {
        [TestMethod]
        public void isAmicableNumberTest()
        {
            int results = 0;
            Assert.IsTrue(AmicableNumber.isAmicableNumber(6, out results) == false);
            Assert.IsTrue(AmicableNumber.isAmicableNumber(220, out results) == true);
        }

        [TestMethod]
        public void GetAllAmicableNumbersTest()
        {
           

            int results = AmicableNumber.GetAllAmicableNumbers(10000);


            Assert.IsTrue(results == 31626);
        }
    }
}