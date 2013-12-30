
using CTMK.Utility;
using System.Collections.Generic;
namespace CTMK.Control.State
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
            up = new ButtonState("UP");
            down = new ButtonState("DOWN");
            left = new ButtonState("LEFT");
            right = new ButtonState("RIGHT");
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
