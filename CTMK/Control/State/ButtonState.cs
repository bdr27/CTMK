
namespace CTMK.Control.State
{
    public class ButtonState
    {

        private string name;
        private bool down = false;
        private bool released = false;

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
            down = false;
            released = true;
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
