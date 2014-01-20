using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMK_API.Control.CTState
{
    public class ButtonState
    {

        private string name;
        private bool down = false;
        private bool released = false;
        //private GamepadButtonFlags gamepadButtonFlags;

        public ButtonState(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void ButtonDown()
        {
            released = false;
            down = true;
        }

        public void ButtonUp()
        {
            if (down == true)
            {
                down = false;
                released = true;
            }
        }

        public bool GetDown()
        {
            return down;
        }

        public bool GetReleased()
        {
            if (released)
            {
                released = false;
                return true;
            }
            return false;
        }
    }
}
