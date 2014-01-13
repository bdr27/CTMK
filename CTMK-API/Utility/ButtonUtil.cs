using CTMK_API.Control.CTState;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTMK_API.Utility
{
    public static class ButtonUtil
    {
        public static List<ButtonState> GetListButtons(params ButtonState[] buttonStates)
        {
            var buttons = new List<ButtonState>();
            foreach (var buttonState in buttonStates)
            {
                buttons.Add(buttonState);
            }
            return buttons;
        }
    }
}
