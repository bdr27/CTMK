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
            switch(pressed.ToUpper())
            {
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
                case "D1":
                    key = VirtualKeyCode.VK_1;
                    break;
                default:
                    //Change to a better exception
                    throw new NotImplementedException();
            }
            return key;
        }
    }
}
