using SlimDX;
using SlimDX.XInput;

namespace CTMK.Control.CTState
{
    public class ThumbstickState
    {
        private string name;
        private Vector2 position;
        private ButtonState click;
        private DPadState dPad;

        public ThumbstickState(string name, GamepadButtonFlags gamepadButtonFlags)
        {
            this.name = name;
            click = new ButtonState(name, gamepadButtonFlags);
            dPad = new DPadState(name);
        }

        public DPadState GetDpad()
        {
            return dPad;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPosition(Vector2 position)
        {
            this.position = position;
        }

        public float GetX()
        {
            return position.X;
        }

        public float GetY()
        {
            return position.Y;
        }

        public ButtonState GetButton()
        {
            return click;
        }
    }
}
