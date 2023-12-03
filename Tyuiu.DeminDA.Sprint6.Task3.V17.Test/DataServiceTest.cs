using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DeminDA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.DeminDA.Sprint6.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                {  14,   5,  -9,  18,  21 },
                {  -5, -12, -12,   4,  28 },
                {  27,  -2, -14,  23,  27 },
                { -19, -15,  17,  15,   1 },
                {  33,   2,   6,  24,  24 }
            };

            int[,] wait = {
                {  14,   5, -9,   4,  21 },
                {  -5, -12, -12,  15,  28 },
                {  27,  -2, -14,  18,  27 },
                { -19, -15,  17,  23,   1 },
                {  33,   2,   6,  24,  24 }
            };

            int[,] res = ds.Calculate(matrix);


            CollectionAssert.AreEqual(wait, res);
        }
    }
}
