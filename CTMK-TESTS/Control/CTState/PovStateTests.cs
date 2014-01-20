using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTMK_API.Control.CTState;

namespace CTMK_TESTS.Control.CTState
{
    [TestClass]
    public class PovStateTests
    {
        [TestMethod]
        public void PovStateNameTest()
        {
            var name = "DPAD";
            var pov = new PovState(name);
            Assert.AreEqual(name, pov.GetName());
        }

        [TestMethod]
        public void PovStateNoneTest()
        {
            var name = "DPAD";
            var pov = new PovState(name);
            Assert.AreEqual(0, pov.GetButtonsDown().Count);
        }

        [TestMethod]
        public void PovStateAroundTheWorldNewPovTest()
        {
            var name = "DPAD";

            PovTest("UP", 0, new PovState(name));
            PovTest("DOWN", 18000, new PovState(name));
            PovTest("LEFT", 27000, new PovState(name));
            PovTest("RIGHT", 9000, new PovState(name));
        }

        [TestMethod]
        public void PovStateAroundTheWorldSamePovTest()
        {
            var name = "DPAD";
            var pov = new PovState(name);
            PovTest("UP", 0, pov);
            PovTest("DOWN", 18000, pov);
            PovTest("LEFT", 27000, pov);
            PovTest("RIGHT", 9000, pov);
        }

        private void PovTest(string name, short position, PovState pov)
        {
            pov.SetPosition(position);
            pov.UpdatePov();
            var buttons = pov.GetButtonsDown();
            Assert.AreEqual(1, buttons.Count);
            Assert.AreEqual(name, buttons[0].GetName());
        }
    }
}
