using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint2.Task4.V13.Lib;

namespace Tyuiu.GrigorjanAM.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 169;
            double y = 2;
            double res = Math.Round(ds.Calculate(x, y),3);
            double wait = 188.994;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 150;
            double res = Math.Round(ds.Calculate(x, y),3);
            double wait = 0.005;
            Assert.AreEqual(res, wait);

        }
    }
}
