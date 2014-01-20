using CTMK_API.Control.CTState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

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


        public static VirtualKeyCode KeyToVirtualKey(string pressed)
        {
            VirtualKeyCode key;
            switch (pressed.ToUpper())
            {

                #region OEM
                case "OEM1":
                    key = VirtualKeyCode.OEM_1;
                    break;
                case "OEM2":
                    key = VirtualKeyCode.OEM_2;
                    break;
                case "OEM3":
                    key = VirtualKeyCode.OEM_3;
                    break;
                case "OEMOPENBRACKETS":
                case "OEM4":
                    key = VirtualKeyCode.OEM_4;
                    break;
                case "OEM5":
                    key = VirtualKeyCode.OEM_5;
                    break;
                case "OEM6":
                    key = VirtualKeyCode.OEM_6;
                    break;
                case "OEM7":
                    key = VirtualKeyCode.OEM_7;
                    break;
                case "OEM8":
                    key = VirtualKeyCode.OEM_8;
                    break;
                case "OEM102":
                    key = VirtualKeyCode.OEM_102;
                    break;
                case "OEMMINUS":
                    key = VirtualKeyCode.OEM_MINUS;
                    break;
                case "OEMPLUS":
                    key = VirtualKeyCode.OEM_PLUS;
                    break;
                case "OEMCLEAR":
                    key = VirtualKeyCode.OEM_CLEAR;
                    break;
                case "OEMCOMMA":
                    key = VirtualKeyCode.OEM_COMMA;
                    break;
                case "OEMPERIOD":
                    key = VirtualKeyCode.OEM_PERIOD;
                    break;
                #endregion

                #region F Keys
                case "F1":
                    key = VirtualKeyCode.F1;
                    break;
                case "F2":
                    key = VirtualKeyCode.F2;
                    break;
                case "F3":
                    key = VirtualKeyCode.F3;
                    break;
                case "F4":
                    key = VirtualKeyCode.F4;
                    break;
                case "F5":
                    key = VirtualKeyCode.F5;
                    break;
                case "F6":
                    key = VirtualKeyCode.F6;
                    break;
                case "F7":
                    key = VirtualKeyCode.F7;
                    break;
                case "F8":
                    key = VirtualKeyCode.F8;
                    break;
                case "F9":
                    key = VirtualKeyCode.F9;
                    break;
                case "F10":
                    key = VirtualKeyCode.F10;
                    break;
                case "F11":
                    key = VirtualKeyCode.F11;
                    break;
                case "F12":
                    key = VirtualKeyCode.F12;
                    break;
                #endregion

                #region Middle
                case "UP":
                    key = VirtualKeyCode.UP;
                    break;
                case "DOWN":
                    key = VirtualKeyCode.DOWN;
                    break;
                case "LEFT":
                    key = VirtualKeyCode.LEFT;
                    break;
                case "RIGHT":
                    key = VirtualKeyCode.RIGHT;
                    break;
                case "DELETE":
                    key = VirtualKeyCode.DELETE;
                    break;
                case "NEXT":
                    key = VirtualKeyCode.NEXT;
                    break;
                case "END":
                    key = VirtualKeyCode.END;
                    break;
                case "PAGEUP":
                    key = VirtualKeyCode.PRIOR;
                    break;
                case "HOME":
                    key = VirtualKeyCode.HOME;
                    break;
                case "INSERT":
                    key = VirtualKeyCode.INSERT;
                    break;
                case "SNAPSHOT":
                    key = VirtualKeyCode.SNAPSHOT;
                    break;
                case "SCROLL":
                    key = VirtualKeyCode.SCROLL;
                    break;
                case "PAUSE":
                    key = VirtualKeyCode.PAUSE;
                    break;
                #endregion

                #region NumPad
                case "NUMLOCK":
                    key = VirtualKeyCode.NUMLOCK;
                    break;
                case "NUMPAD0":
                    key = VirtualKeyCode.NUMPAD0;
                    break;
                case "NUMPAD1":
                    key = VirtualKeyCode.NUMPAD1;
                    break;
                case "NUMPAD2":
                    key = VirtualKeyCode.NUMPAD2;
                    break;
                case "NUMPAD3":
                    key = VirtualKeyCode.NUMPAD3;
                    break;
                case "NUMPAD4":
                    key = VirtualKeyCode.NUMPAD4;
                    break;
                case "NUMPAD5":
                    key = VirtualKeyCode.NUMPAD5;
                    break;
                case "NUMPAD6":
                    key = VirtualKeyCode.NUMPAD6;
                    break;
                case "NUMPAD7":
                    key = VirtualKeyCode.NUMPAD7;
                    break;
                case "NUMPAD8":
                    key = VirtualKeyCode.NUMPAD8;
                    break;
                case "NUMPAD9":
                    key = VirtualKeyCode.NUMPAD9;
                    break;
                case "DIVIDE":
                    key = VirtualKeyCode.DIVIDE;
                    break;
                case "MULTIPLY":
                    key = VirtualKeyCode.MULTIPLY;
                    break;
                case "SUBTRACT":
                    key = VirtualKeyCode.SUBTRACT;
                    break;
                case "ADD":
                    key = VirtualKeyCode.ADD;
                    break;
                case "RETURN":
                    key = VirtualKeyCode.RETURN;
                    break;
                case "DECIMAL":
                    key = VirtualKeyCode.DECIMAL;
                    break;
                #endregion

                #region Top Row
                case "D1":
                    key = VirtualKeyCode.VK_1;
                    break;
                case "D2":
                    key = VirtualKeyCode.VK_2;
                    break;
                case "D3":
                    key = VirtualKeyCode.VK_3;
                    break;
                case "D4":
                    key = VirtualKeyCode.VK_4;
                    break;
                case "D5":
                    key = VirtualKeyCode.VK_5;
                    break;
                case "D6":
                    key = VirtualKeyCode.VK_6;
                    break;
                case "D7":
                    key = VirtualKeyCode.VK_7;
                    break;
                case "D8":
                    key = VirtualKeyCode.VK_8;
                    break;
                case "D9":
                    key = VirtualKeyCode.VK_9;
                    break;
                case "D0":
                    key = VirtualKeyCode.VK_0;
                    break;
                case "ESCAPE":
                    key = VirtualKeyCode.ESCAPE;
                    break;
                case "BACK":
                    key = VirtualKeyCode.BACK;
                    break;
                #endregion

                #region Second Row
                case "TAB":
                    key = VirtualKeyCode.TAB;
                    break;
                case "Q":
                    key = VirtualKeyCode.VK_Q;
                    break;
                case "W":
                    key = VirtualKeyCode.VK_W;
                    break;
                case "E":
                    key = VirtualKeyCode.VK_E;
                    break;
                case "R":
                    key = VirtualKeyCode.VK_R;
                    break;
                case "T":
                    key = VirtualKeyCode.VK_T;
                    break;
                case "Y":
                    key = VirtualKeyCode.VK_Y;
                    break;
                case "U":
                    key = VirtualKeyCode.VK_U;
                    break;
                case "I":
                    key = VirtualKeyCode.VK_I;
                    break;
                case "O":
                    key = VirtualKeyCode.VK_O;
                    break;
                case "P":
                    key = VirtualKeyCode.VK_P;
                    break;

                #endregion

                #region Third Row
                case "CAPTIAL":
                    key = VirtualKeyCode.CAPITAL;
                    break;
                case "A":
                    key = VirtualKeyCode.VK_A;
                    break;
                case "S":
                    key = VirtualKeyCode.VK_S;
                    break;
                case "F":
                    key = VirtualKeyCode.VK_F;
                    break;
                case "G":
                    key = VirtualKeyCode.VK_G;
                    break;
                case "H":
                    key = VirtualKeyCode.VK_H;
                    break;
                case "J":
                    key = VirtualKeyCode.VK_J;
                    break;
                case "K":
                    key = VirtualKeyCode.VK_K;
                    break;
                case "L":
                    key = VirtualKeyCode.VK_L;
                    break;
                #endregion

                #region Forth Row
                case "LEFTSHIFT":
                    key = VirtualKeyCode.LSHIFT;
                    break;
                case "RIGHTSHIFT":
                    key = VirtualKeyCode.RSHIFT;
                    break;
                case "SHIFT":
                    key = VirtualKeyCode.SHIFT;
                    break;
                case "Z":
                    key = VirtualKeyCode.VK_Z;
                    break;
                case "X":
                    key = VirtualKeyCode.VK_X;
                    break;
                case "C":
                    key = VirtualKeyCode.VK_C;
                    break;
                case "V":
                    key = VirtualKeyCode.VK_V;
                    break;
                case "B":
                    key = VirtualKeyCode.VK_B;
                    break;
                case "N":
                    key = VirtualKeyCode.VK_N;
                    break;
                case "M":
                    key = VirtualKeyCode.VK_M;
                    break;

                #endregion

                #region Fifth Row
                case "LEFTCTRL":
                    key = VirtualKeyCode.LCONTROL;
                    break;
                case "RIGHTCTRL":
                    key = VirtualKeyCode.RCONTROL;
                    break;
                case "CTRL":
                    key = VirtualKeyCode.CONTROL;
                    break;
                case "LEFTALT":
                    key = VirtualKeyCode.LMENU;
                    break;
                case "RIGHTALT":
                    key = VirtualKeyCode.RMENU;
                    break;
                case "ALT":
                    key = VirtualKeyCode.MENU;
                    break;
                case "SPACE":
                    key = VirtualKeyCode.SPACE;
                    break;
                case "LWIN":
                    key = VirtualKeyCode.LWIN;
                    break;
                case "RWIN":
                    key = VirtualKeyCode.RWIN;
                    break;
                #endregion

                default:
                    //Change to a better exception
                    throw new NotImplementedException();
            }
            return key;
        }
    }
}
