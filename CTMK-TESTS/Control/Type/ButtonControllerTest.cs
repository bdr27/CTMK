using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTMK_API.Control.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTMK_API.Utility;
using CTMK_API.Control.CTState;
using WindowsInput.Native;

namespace CTMK_TESTS.Control.Type
{
    [TestClass]
    public class ButtonLookUpTest
    {
        Dictionary<ButtonState, VirtualKeyCode> dict;

        public ButtonLookUpTest()
        {
            dict = new Dictionary<ButtonState, VirtualKeyCode>();
            dict.Add(new ButtonState("X"), VirtualKeyCode.BACK);

        }

        [TestMethod]
        public void ButtonControllerGetButtonTest()
        {
            var bl = new ButtonLookUp();
        }
    }
}
