using CTMK_API.Control.CTState;
using SlimDX.XInput;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTMK_API.Utility
{
    public static class XInputButtonFlagLookup
    {
        public static GamepadButtonFlags ConvertButton(ButtonState button)
        {
            return GetGamepadButtonFlag(button.GetName());
        }
        public static GamepadButtonFlags ConvertButton(string button)
        {
            return GetGamepadButtonFlag(button);
        }

        private static GamepadButtonFlags GetGamepadButtonFlag(string button)
        {
            GamepadButtonFlags flag;
            switch(button.ToUpper())
            {
                case "A":
                    flag = GamepadButtonFlags.A;
                    break;
                case "B":
                    flag = GamepadButtonFlags.B;
                    break;
                case "X":
                    flag = GamepadButtonFlags.X;
                    break;
                case "Y":
                    flag = GamepadButtonFlags.Y;
                    break;
                case "START":
                    flag = GamepadButtonFlags.Start;
                    break;
                case "BACK":
                    flag = GamepadButtonFlags.Back;
                    break;
                case "LT":
                    flag = GamepadButtonFlags.LeftThumb;
                    break;
                case "RT":
                    flag = GamepadButtonFlags.RightThumb;
                    break;
                case "LS":
                    flag = GamepadButtonFlags.LeftShoulder;
                    break;
                case "RS":
                    flag = GamepadButtonFlags.RightShoulder;
                    break;
                default:
                    flag = GamepadButtonFlags.None;
                    break;
            }
            return flag;
        }

        public static Dictionary<string, GamepadButtonFlags> ConvertButtons(List<string> buttons)
        {
            var flags = new Dictionary<string, GamepadButtonFlags>();
            foreach (var button in buttons)
            {
                if (!flags.ContainsKey(button))
                {
                    flags.Add(button, GetGamepadButtonFlag(button));
                }
            }
            return flags;
        }

        public static Dictionary<string, GamepadButtonFlags> ConvertButtons(List<ButtonState> buttons)
        {
            var listButtons = new List<string>();
            foreach(var button in buttons)
            {
                listButtons.Add(button.GetName());
            }
            return ConvertButtons(listButtons);
        }

        /*public static string ConvertFlags(List<GamepadButtonFlags> buttonFlags)
        {
            throw new NotImplementedException();
        }*/

        /*public static string ConvertFlag(GamepadButtonFlags buttonFlag)
        {
            throw new NotImplementedException();
        }*/
    }
}
