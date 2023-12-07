using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DreminIa.Sprint1.Task3.V1.Lib;

namespace Tyuiu.DreminIa.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            double wait = 37.699;
            var res = ds.CylinderVolume(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}