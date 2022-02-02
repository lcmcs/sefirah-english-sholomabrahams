using System;
using ConsoleAppTemplate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RangeTest()
        {
            Assert.ThrowsException<ArgumentException>(() => Program.GetEnglishSefira(-5));
            Assert.ThrowsException<ArgumentException>(() => Program.GetEnglishSefira(0));
            Assert.ThrowsException<ArgumentException>(() => Program.GetEnglishSefira(50));
        }

        [TestMethod]
        public void EnglishTest()
        {
            Assert.AreEqual(Program.GetEnglishSefira(7), "Today is seven days, which are one week of the Omer.");
            Assert.AreEqual(Program.GetEnglishSefira(47), "Today is forty-seven days, which are six weeks and five days of the Omer.");
            Assert.AreEqual(Program.GetEnglishSefira(1), "Today is one day of the Omer.");
            Assert.AreEqual(Program.GetEnglishSefira(23), "Today is twenty-three days, which are three weeks and two days of the Omer.");
        }
    }
}