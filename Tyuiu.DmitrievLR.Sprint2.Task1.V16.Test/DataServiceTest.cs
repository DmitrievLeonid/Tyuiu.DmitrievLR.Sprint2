using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint2.Task1.V16.Lib;

namespace Tyuiu.DmitrievLR.Sprint2.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 145, b = 716, c = 144, d = 137;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
