using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTMK_API.Control.CTState;

namespace CTMK_TESTS.Control.CTState
{
    [TestClass]
    public class ButtonStateTests
    {
        [TestMethod]
        public void ButtonStateNameTest()
        {
            string name = "X";
            ButtonState button = new ButtonState(name);
            Assert.AreEqual(button.GetName(), name);
            Assert.IsFalse(button.GetDown());
            Assert.IsFalse(button.GetReleased());
        }

        [TestMethod]
        public void ButtonStateDownTest()
        {
            string name = "X";
            ButtonState button = new ButtonState(name);
            button.ButtonDown();
            Assert.IsTrue(button.GetDown());
            Assert.IsFalse(button.GetReleased());
        }

        [TestMethod]
        public void ButtonStateReleasedTest()
        {
            string name = "X";
            ButtonState button = new ButtonState(name);
            button.ButtonDown();
            button.ButtonUp();
            Assert.IsFalse(button.GetDown());
            Assert.IsTrue(button.GetReleased());
        }
    }
}
