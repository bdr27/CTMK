using CTMK_API.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMK_API.Control.CTState
{
    public class PovState
    {
        private string name;
        private short position = -1;
        private ButtonState up;
        private ButtonState down;
        private ButtonState left;
        private ButtonState right;
        private List<ButtonState> buttons;

        public PovState(string name)
        {
            this.name = name;
            up = new ButtonState("UP");
            down = new ButtonState("DOWN");
            left = new ButtonState("LEFT");
            right = new ButtonState("RIGHT");
            buttons = ButtonUtil.GetListButtons(up, down, left, right);
        }

        public void SetPosition(short position)
        {
            this.position = position;          
        }

        public void UpdatePov()
        {
            var buttonsDown = new List<string>();
            if (position != -1)
            {
                var temp = position / 4500;
                switch (temp)
                {
                    case 0:
                        buttonsDown.Add(up.GetName());
                        break;
                    case 1:
                        buttonsDown.Add(up.GetName());
                        buttonsDown.Add(right.GetName());
                        break;
                    case 2:
                        buttonsDown.Add(right.GetName());
                        break;
                    case 3:
                        buttonsDown.Add(right.GetName());
                        buttonsDown.Add(down.GetName());
                        break;
                    case 4:
                        buttonsDown.Add(down.GetName());
                        break;
                    case 5:
                        buttonsDown.Add(down.GetName());
                        buttonsDown.Add(left.GetName());
                        break;
                    case 6:
                        buttonsDown.Add(left.GetName());
                        break;
                    case 7:
                        buttonsDown.Add(left.GetName());
                        buttonsDown.Add(up.GetName());
                        break;
                }
            }
            UpdateButtons(buttonsDown);
        }

        private void UpdateButtons(List<string> down)
        {
            foreach (var button in buttons)
            {
                if (down.Contains(button.GetName()))
                {
                    button.ButtonDown();
                }
                else
                {
                    button.ButtonUp();
                }
            }
        }

        public void SetReleased(params ButtonState[] buttons)
        {
            foreach (var button in buttons)
            {
                button.ButtonUp();
            }
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

        public List<ButtonState> GetButtonsDown()
        {
            var down = new List<ButtonState>();
            foreach (var button in buttons)
            {
                if (button.GetDown())
                {
                    down.Add(button);
                }
            }
            return down;
        }

        public List<ButtonState> GetButtonsReleased()
        {
            var released = new List<ButtonState>();
            foreach (var button in buttons)
            {
                if (button.GetReleased())
                {
                    released.Add(button);
                }
            }
            return released;
        }

        public string GetName()
        {
            return name;
        }
    }
}
