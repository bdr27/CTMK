
namespace CTMK.Control.Utility
{
    public class Button
    {

        private string name;
        private bool down = false;
        private bool released = false;

        public Button(string name)
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
