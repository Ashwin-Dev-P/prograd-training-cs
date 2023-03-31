using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverTimePay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTimePay.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void OverTimeTest()
        {
            double[] arr = { 13.25, 15, 30, 1.5 };
            Assert.AreEqual(Program.OverTime(arr), 52.5);
           
        }

        [TestMethod()]
        public void OverTimeTest2()
        {
            double[] arr = { 16, 18, 30, 1.8 };
            Assert.AreEqual(Program.OverTime(arr), 84);

        }

        
        [TestMethod()]
        public void OverTimeTest3()
        {
            double[] arr = { 9, 17, 30, 1.5 };
            Assert.AreEqual(Program.OverTime(arr), 240);

        }
    }
}