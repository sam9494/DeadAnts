using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAnts
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void ant_ant_ant_ant_should_be_0()
        {
            DeadAntsShouldBe(0, "ant ant ant ant");
        }
        [TestMethod]
        public void no_ants_should_be_0()
        {
            DeadAntsShouldBe(0, null);
        }
        [TestMethod]
        public void ant_anantt_aantnt_should_be_2()
        {
            DeadAntsShouldBe(2, "ant anantt aantnt");
        }
        [TestMethod]
        public void ant_ant_a_nt_should_be_1()
        {
            DeadAntsShouldBe(1, "ant ant .... a nt");
        }
        private void DeadAntsShouldBe(int expect, string input)
        {
            Assert.AreEqual(expect, Ants.CountDead(input));
        }
    }
}
