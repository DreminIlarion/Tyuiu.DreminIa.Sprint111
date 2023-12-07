using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint1.Task6.V3.Lib;

namespace Tyuiu.DreminIa.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string words = "Привет как дела";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(words);
            Assert.AreEqual("тка", res);
        }

    }
}