using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTMK_API.Utility;
using WindowsInput.Native;

namespace CTMK_TESTS.Utility
{
    [TestClass]
    public class ButtonUtilTests
    {
        [TestMethod]
        public void ButtonUtilTestsKeyToVirtualKeyTests()
        {
            var key = ButtonUtil.KeyToVirtualKey("UP");
            Assert.AreEqual(VirtualKeyCode.UP, key);

            key = ButtonUtil.KeyToVirtualKey("NumLock");
            Assert.AreEqual(VirtualKeyCode.NUMLOCK, key);
            
            key = ButtonUtil.KeyToVirtualKey("Divide");
            Assert.AreEqual(VirtualKeyCode.DIVIDE, key);
            
            key = ButtonUtil.KeyToVirtualKey("Multiply");
            Assert.AreEqual(VirtualKeyCode.MULTIPLY, key);
            
            key = ButtonUtil.KeyToVirtualKey("Subtract");
            Assert.AreEqual(VirtualKeyCode.SUBTRACT, key);
            
            key = ButtonUtil.KeyToVirtualKey("Add");
            Assert.AreEqual(VirtualKeyCode.ADD, key);
            
            key = ButtonUtil.KeyToVirtualKey("Return");
            Assert.AreEqual(VirtualKeyCode.RETURN, key);
            
            key = ButtonUtil.KeyToVirtualKey("Decimal");
            Assert.AreEqual(VirtualKeyCode.DECIMAL, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad0");
            Assert.AreEqual(VirtualKeyCode.NUMPAD0, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad1");
            Assert.AreEqual(VirtualKeyCode.NUMPAD1, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad2");
            Assert.AreEqual(VirtualKeyCode.NUMPAD2, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad3");
            Assert.AreEqual(VirtualKeyCode.NUMPAD3, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad4");
            Assert.AreEqual(VirtualKeyCode.NUMPAD4, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad5");
            Assert.AreEqual(VirtualKeyCode.NUMPAD5, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad6");
            Assert.AreEqual(VirtualKeyCode.NUMPAD6, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad7");
            Assert.AreEqual(VirtualKeyCode.NUMPAD7, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad8");
            Assert.AreEqual(VirtualKeyCode.NUMPAD8, key);

            key = ButtonUtil.KeyToVirtualKey("NumPad9");
            Assert.AreEqual(VirtualKeyCode.NUMPAD9, key);
        }
    }
}
