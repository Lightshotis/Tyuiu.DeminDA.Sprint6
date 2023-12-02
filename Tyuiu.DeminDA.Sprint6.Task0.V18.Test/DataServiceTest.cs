using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint6.Task0.V18.Lib;

namespace Tyuiu.DeminDA.Sprint6.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double wait = 1.056;
            double res = ds.Calculate(3);
            Assert.AreEqual(wait, res);
        }
    }
}
