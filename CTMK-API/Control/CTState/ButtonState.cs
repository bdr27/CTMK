
using SlimDX.XInput;

namespace CTMK_API.Control.CTState
{
    public class ButtonState
    {

        private string name;
        private bool down = false;
        private bool released = false;
        private GamepadButtonFlags gamepadButtonFlags;

        public ButtonState(string name, GamepadButtonFlags gamepadButtonFlags)
        {
            this.name = name;
            this.gamepadButtonFlags = gamepadButtonFlags;
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

        public GamepadButtonFlags GetGamepadButtonFlags()
        {
            return gamepadButtonFlags;
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
