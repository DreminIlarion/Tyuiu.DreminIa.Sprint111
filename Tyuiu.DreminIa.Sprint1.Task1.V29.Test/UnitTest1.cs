using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint1.Task1.V29.Lib;

namespace Tyuiu.DreminIa.Sprint1.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExxpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double b = 2.0;
            double c = 3.0;
            var res = ds.Calculate(a, b, c);

            Assert.AreEqual(1, res);
        }
    }
}