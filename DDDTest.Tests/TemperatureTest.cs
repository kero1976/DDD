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

        [TestMethod]
        public void 同値確認()
        {
            var t1 = new Temperature(12.3f);
            var t2 = new Temperature(12.3f);
            Assert.AreEqual(t1, t2);

        }

    }
}
