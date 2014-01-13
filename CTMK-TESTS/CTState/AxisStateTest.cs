using CTMK_API.Control.CTState;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTMK_TESTS.CTState
{
    [TestClass]
    public class AxisStateTest
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
            var axis = new AxisState("X");
            axis.SetAxis(3762);
            Assert.AreEqual(3762, axis.GetAxis());
        }
    }
}
