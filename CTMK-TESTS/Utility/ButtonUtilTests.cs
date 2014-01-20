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

            #region OEM
            key = ButtonUtil.KeyToVirtualKey("Oem1");
            Assert.AreEqual(VirtualKeyCode.OEM_1, key);

            key = ButtonUtil.KeyToVirtualKey("Oem2");
            Assert.AreEqual(VirtualKeyCode.OEM_2, key);

            key = ButtonUtil.KeyToVirtualKey("Oem3");
            Assert.AreEqual(VirtualKeyCode.OEM_3, key);

            key = ButtonUtil.KeyToVirtualKey("OemOpenBrackets");
            Assert.AreEqual(VirtualKeyCode.OEM_4, key);

            key = ButtonUtil.KeyToVirtualKey("Oem4");
            Assert.AreEqual(VirtualKeyCode.OEM_4, key);

            key = ButtonUtil.KeyToVirtualKey("Oem5");
            Assert.AreEqual(VirtualKeyCode.OEM_5, key);

            key = ButtonUtil.KeyToVirtualKey("Oem6");
            Assert.AreEqual(VirtualKeyCode.OEM_6, key);

            key = ButtonUtil.KeyToVirtualKey("Oem7");
            Assert.AreEqual(VirtualKeyCode.OEM_7, key);

            key = ButtonUtil.KeyToVirtualKey("Oem8");
            Assert.AreEqual(VirtualKeyCode.OEM_8, key);

            key = ButtonUtil.KeyToVirtualKey("Oem102");
            Assert.AreEqual(VirtualKeyCode.OEM_102, key);

            key = ButtonUtil.KeyToVirtualKey("OemMinus");
            Assert.AreEqual(VirtualKeyCode.OEM_MINUS, key);

            key = ButtonUtil.KeyToVirtualKey("OemPlus");
            Assert.AreEqual(VirtualKeyCode.OEM_PLUS, key);

            key = ButtonUtil.KeyToVirtualKey("OemClear");
            Assert.AreEqual(VirtualKeyCode.OEM_CLEAR, key);

            key = ButtonUtil.KeyToVirtualKey("OemComma");
            Assert.AreEqual(VirtualKeyCode.OEM_COMMA, key);

            key = ButtonUtil.KeyToVirtualKey("OemPeriod");
            Assert.AreEqual(VirtualKeyCode.OEM_PERIOD, key);
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

            #region Top Row
            key = ButtonUtil.KeyToVirtualKey("D1");
            Assert.AreEqual(VirtualKeyCode.VK_1, key);

            key = ButtonUtil.KeyToVirtualKey("D2");
            Assert.AreEqual(VirtualKeyCode.VK_2, key);

            key = ButtonUtil.KeyToVirtualKey("D3");
            Assert.AreEqual(VirtualKeyCode.VK_3, key);

            key = ButtonUtil.KeyToVirtualKey("D4");
            Assert.AreEqual(VirtualKeyCode.VK_4, key);

            key = ButtonUtil.KeyToVirtualKey("D5");
            Assert.AreEqual(VirtualKeyCode.VK_5, key);

            key = ButtonUtil.KeyToVirtualKey("D6");
            Assert.AreEqual(VirtualKeyCode.VK_6, key);

            key = ButtonUtil.KeyToVirtualKey("D7");
            Assert.AreEqual(VirtualKeyCode.VK_7, key);

            key = ButtonUtil.KeyToVirtualKey("D8");
            Assert.AreEqual(VirtualKeyCode.VK_8, key);

            key = ButtonUtil.KeyToVirtualKey("D9");
            Assert.AreEqual(VirtualKeyCode.VK_9, key);

            key = ButtonUtil.KeyToVirtualKey("D0");
            Assert.AreEqual(VirtualKeyCode.VK_0, key);

            key = ButtonUtil.KeyToVirtualKey("Escape");
            Assert.AreEqual(VirtualKeyCode.ESCAPE, key);

            key = ButtonUtil.KeyToVirtualKey("Back");
            Assert.AreEqual(VirtualKeyCode.BACK, key);
            #endregion

            #region Second Row

            key = ButtonUtil.KeyToVirtualKey("Tab");
            Assert.AreEqual(VirtualKeyCode.TAB, key);

            key = ButtonUtil.KeyToVirtualKey("Q");
            Assert.AreEqual(VirtualKeyCode.VK_Q, key);

            key = ButtonUtil.KeyToVirtualKey("W");
            Assert.AreEqual(VirtualKeyCode.VK_W, key);

            key = ButtonUtil.KeyToVirtualKey("E");
            Assert.AreEqual(VirtualKeyCode.VK_E, key);

            key = ButtonUtil.KeyToVirtualKey("R");
            Assert.AreEqual(VirtualKeyCode.VK_R, key);

            key = ButtonUtil.KeyToVirtualKey("T");
            Assert.AreEqual(VirtualKeyCode.VK_T, key);

            key = ButtonUtil.KeyToVirtualKey("Y");
            Assert.AreEqual(VirtualKeyCode.VK_Y, key);

            key = ButtonUtil.KeyToVirtualKey("U");
            Assert.AreEqual(VirtualKeyCode.VK_U, key);

            key = ButtonUtil.KeyToVirtualKey("I");
            Assert.AreEqual(VirtualKeyCode.VK_I, key);

            key = ButtonUtil.KeyToVirtualKey("O");
            Assert.AreEqual(VirtualKeyCode.VK_O, key);

            key = ButtonUtil.KeyToVirtualKey("P");
            Assert.AreEqual(VirtualKeyCode.VK_P, key);
            #endregion

            #region Third Row
            key = ButtonUtil.KeyToVirtualKey("Captial");
            Assert.AreEqual(VirtualKeyCode.CAPITAL, key);
            
            key = ButtonUtil.KeyToVirtualKey("A");
            Assert.AreEqual(VirtualKeyCode.VK_A, key);

            key = ButtonUtil.KeyToVirtualKey("S");
            Assert.AreEqual(VirtualKeyCode.VK_S, key);

            key = ButtonUtil.KeyToVirtualKey("F");
            Assert.AreEqual(VirtualKeyCode.VK_F, key);

            key = ButtonUtil.KeyToVirtualKey("G");
            Assert.AreEqual(VirtualKeyCode.VK_G, key);

            key = ButtonUtil.KeyToVirtualKey("H");
            Assert.AreEqual(VirtualKeyCode.VK_H, key);

            key = ButtonUtil.KeyToVirtualKey("J");
            Assert.AreEqual(VirtualKeyCode.VK_J, key);

            key = ButtonUtil.KeyToVirtualKey("K");
            Assert.AreEqual(VirtualKeyCode.VK_K, key);

            key = ButtonUtil.KeyToVirtualKey("L");
            Assert.AreEqual(VirtualKeyCode.VK_L, key);

            key = ButtonUtil.KeyToVirtualKey("Return");
            Assert.AreEqual(VirtualKeyCode.RETURN, key);
            #endregion

            #region Forth Row
            key = ButtonUtil.KeyToVirtualKey("LeftShift");
            Assert.AreEqual(VirtualKeyCode.LSHIFT, key);

            key = ButtonUtil.KeyToVirtualKey("Shift");
            Assert.AreEqual(VirtualKeyCode.SHIFT, key);

            key = ButtonUtil.KeyToVirtualKey("RightShift");
            Assert.AreEqual(VirtualKeyCode.RSHIFT, key);

            key = ButtonUtil.KeyToVirtualKey("Z");
            Assert.AreEqual(VirtualKeyCode.VK_Z, key);

            key = ButtonUtil.KeyToVirtualKey("X");
            Assert.AreEqual(VirtualKeyCode.VK_X, key);

            key = ButtonUtil.KeyToVirtualKey("C");
            Assert.AreEqual(VirtualKeyCode.VK_C, key);

            key = ButtonUtil.KeyToVirtualKey("V");
            Assert.AreEqual(VirtualKeyCode.VK_V, key);

            key = ButtonUtil.KeyToVirtualKey("B");
            Assert.AreEqual(VirtualKeyCode.VK_B, key);

            key = ButtonUtil.KeyToVirtualKey("N");
            Assert.AreEqual(VirtualKeyCode.VK_N, key);

            key = ButtonUtil.KeyToVirtualKey("M");
            Assert.AreEqual(VirtualKeyCode.VK_M, key);

            #endregion

            #region Fifth Row
            key = ButtonUtil.KeyToVirtualKey("LeftCtrl");
            Assert.AreEqual(VirtualKeyCode.LCONTROL, key);

            key = ButtonUtil.KeyToVirtualKey("RightCtrl");
            Assert.AreEqual(VirtualKeyCode.RCONTROL, key);

            key = ButtonUtil.KeyToVirtualKey("Ctrl");
            Assert.AreEqual(VirtualKeyCode.CONTROL, key);

            key = ButtonUtil.KeyToVirtualKey("LeftAlt");
            Assert.AreEqual(VirtualKeyCode.LMENU, key);

            key = ButtonUtil.KeyToVirtualKey("RightAlt");
            Assert.AreEqual(VirtualKeyCode.RMENU, key);

            key = ButtonUtil.KeyToVirtualKey("Alt");
            Assert.AreEqual(VirtualKeyCode.MENU, key);

            key = ButtonUtil.KeyToVirtualKey("Space");
            Assert.AreEqual(VirtualKeyCode.SPACE, key);

            key = ButtonUtil.KeyToVirtualKey("LWin");
            Assert.AreEqual(VirtualKeyCode.LWIN, key);

            key = ButtonUtil.KeyToVirtualKey("RWin");
            Assert.AreEqual(VirtualKeyCode.RWIN, key);

            key = ButtonUtil.KeyToVirtualKey("NumLock");
            Assert.AreEqual(VirtualKeyCode.NUMLOCK, key);
            #endregion
        }
    }
}
