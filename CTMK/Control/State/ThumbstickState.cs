using SlimDX;

namespace CTMK.Control.State
{
    public class ThumbstickState
    {
        private string name;
        private Vector2 position;
        private ButtonState click;

        public ThumbstickState(string name)
        {
            this.name = name;
            click = new ButtonState(name);
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
