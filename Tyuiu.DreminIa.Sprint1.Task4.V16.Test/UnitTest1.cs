using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint1.Task4.V16.Lib;

namespace Tyuiu.DreminIa.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 0.167;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}