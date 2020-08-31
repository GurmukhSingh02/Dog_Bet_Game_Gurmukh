using System;
using Dog_Bet_Game_Gurmukh;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dog_Bet_Game_GurmukhTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GurmukhGreyHoundClass gghc = new GurmukhGreyHoundClass();
            if (gghc.moveMent() > 10)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
