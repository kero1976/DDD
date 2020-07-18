using System;
using DDD.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void 小数点以下２桁で丸めて表示()
        {
            var t = new Temperature(12.3f);
            Assert.AreEqual(12.3f, t.Value);
            Assert.AreEqual("12.30 ℃", t.DisplayValue);
        }
    }
}
