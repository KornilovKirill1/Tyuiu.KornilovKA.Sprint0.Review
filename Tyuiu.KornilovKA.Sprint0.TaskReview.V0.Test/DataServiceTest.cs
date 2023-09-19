using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KornilovKA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            var res = DataService.Calc(1, 1, 1);
            Assert.AreEqual(15, res);
        }
    }
}
