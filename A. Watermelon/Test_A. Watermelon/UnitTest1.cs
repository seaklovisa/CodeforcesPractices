using A._Watermelon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_A._Watermelon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int watermelonWeight = 1;

            Fruit watermelon = new Watermelon(watermelonWeight);
            string result = watermelon.IsDivideTwoPart();

            Assert.AreEqual("NO", result);

            watermelonWeight = 2;
            watermelon = new Watermelon(watermelonWeight);
            result = watermelon.IsDivideTwoPart();

            Assert.AreEqual("YES", result);

        }
    }
}
