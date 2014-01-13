using CTMK_API.Control.CTState;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlimDX.XInput;

namespace CTMK_TESTS.CTState
{
    [TestClass]
    public class ButtonStateTests
    {
        [TestMethod]
        public void ButtonStateNameTest()
        {
            string name = "X";
            ButtonState button = new ButtonState(name, GamepadButtonFlags.X);
            Assert.AreEqual(button.GetName(), name);
            Assert.IsFalse(button.GetDown());
            Assert.IsFalse(button.GetReleased());
        }

        [TestMethod]
        public void ButtonStateDownTest()
        {
            string name = "X";
            ButtonState button = new ButtonState(name, GamepadButtonFlags.X);
            button.ButtonDown();
            Assert.IsTrue(button.GetDown());
            Assert.IsFalse(button.GetReleased());
        }

        [TestMethod]
        public void ButtonStateReleasedTest()
        {
            string name = "X";
            ButtonState button = new ButtonState(name, GamepadButtonFlags.X);
            button.ButtonDown();
            button.ButtonUp();
            Assert.IsFalse(button.GetDown());
            Assert.IsTrue(button.GetReleased());
        }
    }
}
