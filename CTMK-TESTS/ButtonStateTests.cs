using CTMK.Control.CTState;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTMK_TESTS
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
            button.ButtonUp();
            Assert.IsFalse(button.GetDown());
            Assert.IsTrue(button.GetReleased());
        }
    }
}
