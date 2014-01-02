
using CTMK.Utility;
using SlimDX.XInput;
using System.Collections.Generic;
namespace CTMK.Control.CTState
{
    public class DPadState
    {
        private string name;
        private ButtonState up;
        private ButtonState down;
        private ButtonState left;
        private ButtonState right;
        private List<ButtonState> buttons;

        public DPadState(string name)
        {
            this.name = name;
            up = new ButtonState("UP", GamepadButtonFlags.DPadUp);
            down = new ButtonState("DOWN", GamepadButtonFlags.DPadDown);
            left = new ButtonState("LEFT", GamepadButtonFlags.DPadLeft);
            right = new ButtonState("RIGHT", GamepadButtonFlags.DPadRight);
            buttons = ButtonUtil.GetListButtons(up, down, left, right);
        }

        public ButtonState GetUp()
        {
            return up;
        }

        public ButtonState GetDown()
        {
            return down;
        }

        public ButtonState GetLeft()
        {
            return left;
        }

        public ButtonState GetRight()
        {
            return right;
        }

        public List<ButtonState> GetButtons()
        {
            return buttons;
        }
    }
}
