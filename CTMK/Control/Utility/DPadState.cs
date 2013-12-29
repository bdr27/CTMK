
namespace CTMK.Control.Utility
{
    public class DPadState
    {
        private readonly bool up, down, left, right;

        public DPadState(bool up, bool down, bool left, bool right)
        {
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
        }

        public bool GetUp()
        {
            return up;
        }

        public bool GetDown()
        {
            return down;
        }

        public bool GetLeft()
        {
            return left;
        }

        public bool GetRight()
        {
            return right;
        }
    }
}
