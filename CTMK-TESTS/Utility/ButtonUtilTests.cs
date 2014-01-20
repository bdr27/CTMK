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
            VirtualKeyCode key;
            #region F Keys
            key = ButtonUtil.KeyToVirtualKey("F1");
            Assert.AreEqual(VirtualKeyCode.F1, key);
            
            key = ButtonUtil.KeyToVirtualKey("F2");
            Assert.AreEqual(VirtualKeyCode.F2, key);

            key = ButtonUtil.KeyToVirtualKey("F3");
            Assert.AreEqual(VirtualKeyCode.F3, key);

            key = ButtonUtil.KeyToVirtualKey("F4");
            Assert.AreEqual(VirtualKeyCode.F4, key);

            key = ButtonUtil.KeyToVirtualKey("F5");
            Assert.AreEqual(VirtualKeyCode.F5, key);

            key = ButtonUtil.KeyToVirtualKey("F6");
            Assert.AreEqual(VirtualKeyCode.F6, key);

            key = ButtonUtil.KeyToVirtualKey("F7");
            Assert.AreEqual(VirtualKeyCode.F7, key);

            key = ButtonUtil.KeyToVirtualKey("F8");
            Assert.AreEqual(VirtualKeyCode.F8, key);

            key = ButtonUtil.KeyToVirtualKey("F9");
            Assert.AreEqual(VirtualKeyCode.F9, key);

            key = ButtonUtil.KeyToVirtualKey("F10");
            Assert.AreEqual(VirtualKeyCode.F10, key);

            key = ButtonUtil.KeyToVirtualKey("F11");
            Assert.AreEqual(VirtualKeyCode.F11, key);

            key = ButtonUtil.KeyToVirtualKey("F12");
            Assert.AreEqual(VirtualKeyCode.F12, key);

            key = ButtonUtil.KeyToVirtualKey("F1");
            Assert.AreEqual(VirtualKeyCode.F1, key);
            
            #endregion
            
            #region Middle

            key = ButtonUtil.KeyToVirtualKey("UP");
            Assert.AreEqual(VirtualKeyCode.UP, key);

            key = ButtonUtil.KeyToVirtualKey("DOWN");
            Assert.AreEqual(VirtualKeyCode.DOWN, key);

            key = ButtonUtil.KeyToVirtualKey("LEFT");
            Assert.AreEqual(VirtualKeyCode.LEFT, key);

            key = ButtonUtil.KeyToVirtualKey("RIGHT");
            Assert.AreEqual(VirtualKeyCode.RIGHT, key);

            key = ButtonUtil.KeyToVirtualKey("DELETE");
            Assert.AreEqual(VirtualKeyCode.DELETE, key);

            key = ButtonUtil.KeyToVirtualKey("END");
            Assert.AreEqual(VirtualKeyCode.END, key);

            key = ButtonUtil.KeyToVirtualKey("NEXT");
            Assert.AreEqual(VirtualKeyCode.NEXT, key);

            key = ButtonUtil.KeyToVirtualKey("PAGEUP");
            Assert.AreEqual(VirtualKeyCode.PRIOR, key);

            key = ButtonUtil.KeyToVirtualKey("HOME");
            Assert.AreEqual(VirtualKeyCode.HOME, key);

            key = ButtonUtil.KeyToVirtualKey("INSERT");
            Assert.AreEqual(VirtualKeyCode.INSERT, key);

            key = ButtonUtil.KeyToVirtualKey("SNAPSHOT");
            Assert.AreEqual(VirtualKeyCode.SNAPSHOT, key);

            key = ButtonUtil.KeyToVirtualKey("SCROLL");
            Assert.AreEqual(VirtualKeyCode.SCROLL, key);

            key = ButtonUtil.KeyToVirtualKey("PAUSE");
            Assert.AreEqual(VirtualKeyCode.PAUSE, key);

            #endregion
           
            #region NUMPAD

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

            #endregion
        }
    }
}
