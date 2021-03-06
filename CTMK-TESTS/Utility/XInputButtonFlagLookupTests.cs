﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlimDX.XInput;
using CTMK_API.Utility;
using CTMK_API.Control.CTState;
using System.Collections.Generic;

namespace CTMK_TESTS
{
    [TestClass]
    public class XInputButtonFlagLookupTests
    {
        [TestMethod]
        public void XInputButtonFlagLookupConvertButtonStringTest()
        {
            Assert.AreEqual(GamepadButtonFlags.A, XInputButtonFlagLookup.ConvertButton("A"));
            Assert.AreEqual(GamepadButtonFlags.B, XInputButtonFlagLookup.ConvertButton("B"));
            Assert.AreEqual(GamepadButtonFlags.X, XInputButtonFlagLookup.ConvertButton("X"));
            Assert.AreEqual(GamepadButtonFlags.Y, XInputButtonFlagLookup.ConvertButton("Y"));

            Assert.AreEqual(GamepadButtonFlags.Start, XInputButtonFlagLookup.ConvertButton("START"));
            Assert.AreEqual(GamepadButtonFlags.Back, XInputButtonFlagLookup.ConvertButton("BACK"));

            Assert.AreEqual(GamepadButtonFlags.LeftThumb, XInputButtonFlagLookup.ConvertButton("LT"));
            Assert.AreEqual(GamepadButtonFlags.RightThumb, XInputButtonFlagLookup.ConvertButton("RT"));

            Assert.AreEqual(GamepadButtonFlags.LeftShoulder, XInputButtonFlagLookup.ConvertButton("LS"));
            Assert.AreEqual(GamepadButtonFlags.RightShoulder, XInputButtonFlagLookup.ConvertButton("RS"));

            Assert.AreEqual(GamepadButtonFlags.None, XInputButtonFlagLookup.ConvertButton(""));
        }

        [TestMethod]
        public void XInputButtonFlagLookupConvertButtonButtonTest()
        {
            Assert.AreEqual(GamepadButtonFlags.A, XInputButtonFlagLookup.ConvertButton(new ButtonState("A")));
            Assert.AreEqual(GamepadButtonFlags.B, XInputButtonFlagLookup.ConvertButton(new ButtonState("B")));
            Assert.AreEqual(GamepadButtonFlags.X, XInputButtonFlagLookup.ConvertButton(new ButtonState("X")));
            Assert.AreEqual(GamepadButtonFlags.Y, XInputButtonFlagLookup.ConvertButton(new ButtonState("Y")));

            Assert.AreEqual(GamepadButtonFlags.Start, XInputButtonFlagLookup.ConvertButton(new ButtonState("START")));
            Assert.AreEqual(GamepadButtonFlags.Back, XInputButtonFlagLookup.ConvertButton(new ButtonState("BACK")));

            Assert.AreEqual(GamepadButtonFlags.LeftThumb, XInputButtonFlagLookup.ConvertButton(new ButtonState("LT")));
            Assert.AreEqual(GamepadButtonFlags.RightThumb, XInputButtonFlagLookup.ConvertButton(new ButtonState("RT")));

            Assert.AreEqual(GamepadButtonFlags.LeftShoulder, XInputButtonFlagLookup.ConvertButton(new ButtonState("LS")));
            Assert.AreEqual(GamepadButtonFlags.RightShoulder, XInputButtonFlagLookup.ConvertButton(new ButtonState("RS")));

            Assert.AreEqual(GamepadButtonFlags.None, XInputButtonFlagLookup.ConvertButton(new ButtonState("")));
        }

        [TestMethod]
        public void XInputButtonFlagLookupConvertListButtonButtonTest()
        {
            var list = new List<string>
            {
                "A",
                "B",
                "X",
                "Y",

                "START",
                "BACK",

                "LT",
                "RT",

                "LS",
                "RS",

                "",
                "LS"
            };

            var result = XInputButtonFlagLookup.ConvertButtons(list);

            Assert.AreEqual(GamepadButtonFlags.A, result["A"]);
            Assert.AreEqual(GamepadButtonFlags.B, result["B"]);
            Assert.AreEqual(GamepadButtonFlags.X, result["X"]);
            Assert.AreEqual(GamepadButtonFlags.Y, result["Y"]);

            Assert.AreEqual(GamepadButtonFlags.Start, result["START"]);
            Assert.AreEqual(GamepadButtonFlags.Back, result["BACK"]);

            Assert.AreEqual(GamepadButtonFlags.LeftThumb, result["LT"]);
            Assert.AreEqual(GamepadButtonFlags.RightThumb, result["RT"]);

            Assert.AreEqual(GamepadButtonFlags.LeftShoulder, result["LS"]);
            Assert.AreEqual(GamepadButtonFlags.RightShoulder, result["RS"]);

            Assert.AreEqual(GamepadButtonFlags.None, result[""]);
        }

        [TestMethod]
        public void XInputButtonFlagLookupConvertListButtonStateButtonButtonTest()
        {
            var list = new List<ButtonState>
            {
                new ButtonState("A"),
                new ButtonState("B"),
                new ButtonState("X"),
                new ButtonState("Y"),

                new ButtonState("START"),
                new ButtonState("BACK"),

                new ButtonState("LT"),
                new ButtonState("RT"),

                new ButtonState("LS"),
                new ButtonState("RS"),

                new ButtonState(""),
                new ButtonState("LS")
            };

            var result = XInputButtonFlagLookup.ConvertButtons(list);

            Assert.AreEqual(GamepadButtonFlags.A, result["A"]);
            Assert.AreEqual(GamepadButtonFlags.B, result["B"]);
            Assert.AreEqual(GamepadButtonFlags.X, result["X"]);
            Assert.AreEqual(GamepadButtonFlags.Y, result["Y"]);

            Assert.AreEqual(GamepadButtonFlags.Start, result["START"]);
            Assert.AreEqual(GamepadButtonFlags.Back, result["BACK"]);

            Assert.AreEqual(GamepadButtonFlags.LeftThumb, result["LT"]);
            Assert.AreEqual(GamepadButtonFlags.RightThumb, result["RT"]);

            Assert.AreEqual(GamepadButtonFlags.LeftShoulder, result["LS"]);
            Assert.AreEqual(GamepadButtonFlags.RightShoulder, result["RS"]);

            Assert.AreEqual(GamepadButtonFlags.None, result[""]);
        }
    }
}
