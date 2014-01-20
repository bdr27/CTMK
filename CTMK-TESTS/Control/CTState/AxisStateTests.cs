using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTMK_API.Control.CTState;

namespace CTMK_TESTS.Control.CTState
{
    [TestClass]
    public class AxisStateTests
    {
        [TestMethod]
        public void AxisStateNameTest()
        {
            var axis = new AxisState("X");
            Assert.AreEqual(axis.GetName(), "X");
        }

        [TestMethod]
        public void AxisStateGetAxisTest()
        {
            ushort axisValue = 3762;
            var axis = new AxisState("X");
            axis.SetValue(axisValue);
            Assert.AreEqual(axisValue, axis.GetValue());
            Assert.AreEqual(axisValue, axis.GetMaxValue());
            Assert.AreEqual(axisValue, axis.GetMinValue());
        }

        [TestMethod]
        public void AxisStateMinMaxTest()
        {
            ushort axisValue = 65535 / 2;
            ushort min = 0;
            ushort max = 65535;
            var axis = new AxisState("X");
            axis.SetValue(axisValue);
            axis.SetValue(min);
            axis.SetValue(max);
            axis.SetValue(axisValue);
            Assert.AreEqual(min, axis.GetMinValue());
            Assert.AreEqual(max, axis.GetMaxValue());
            Assert.AreEqual(axisValue, axis.GetValue());
            Assert.AreEqual(axisValue, axis.GetMiddle());
        }
    }
}
