using SlimDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMK.Control.Utility
{
    public class ThumbstickState
    {
        private readonly string name;
        private readonly Vector2 position;
        private readonly bool down;

        public ThumbstickState(string name, Vector2 position, bool down)
        {
            this.name = name;
            this.down = down;
            this.position = position;
        }

        public string GetName()
        {
            return name;
        }

        public float GetX()
        {
            return position.X;
        }

        public float GetY()
        {
            return position.Y;
        }

        public bool GetClicked()
        {
            return down;
        }
    }
}
