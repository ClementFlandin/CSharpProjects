using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_11_14_TestsTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_11_14_TestsTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void divisionParITest()
        {
            int i = 4;

            double result = Program.divisionParI(i);

            Assert.AreEqual(result, 10 / i);
        }
    }
}