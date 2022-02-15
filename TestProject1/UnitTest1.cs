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
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SefiraEnglish.GetEnglishSefira(-5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SefiraEnglish.GetEnglishSefira(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SefiraEnglish.GetEnglishSefira(50));
        }

        [TestMethod]
        public void OneDay()
        {
            Assert.AreEqual(SefiraEnglish.GetEnglishSefira(1), "Today is one day of the Omer.");
        }
        
        [TestMethod]
        public void MultipleDays()
        {
            Assert.AreEqual(SefiraEnglish.GetEnglishSefira(5), "Today is five days of the Omer.");
        }
        
        [TestMethod]
        public void OneWeek()
        {
            Assert.AreEqual(SefiraEnglish.GetEnglishSefira(7), "Today is seven days, which are one week of the Omer.");
        }
        
        [TestMethod]
        public void MultipleWeeks()
        {
            Assert.AreEqual(SefiraEnglish.GetEnglishSefira(35), "Today is thirty-five days, which are five weeks of the Omer.");
        }
        
        [TestMethod]
        public void WeeksAndDays()
        {
            Assert.AreEqual(SefiraEnglish.GetEnglishSefira(47), "Today is forty-seven days, which are six weeks and five days of the Omer.");
        }
    }
}