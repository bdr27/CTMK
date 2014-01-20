using CTMK_API.Control.CTState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace CTMK_API.Control.Type
{
    public class ButtonLookUp
    {
        private Dictionary<ButtonState, VirtualKeyCode> buttonToKey;

        public ButtonLookUp()
        {
            buttonToKey = new Dictionary<ButtonState, VirtualKeyCode>();
        }

        public void SetKey(ButtonState bs, VirtualKeyCode vc)
        {
            buttonToKey.Add(bs, vc);
        }

        public void SetKeys(Dictionary<ButtonState, VirtualKeyCode> keys)
        {
            buttonToKey.Clear();
            buttonToKey = keys;
        }

        public Dictionary<ButtonState, VirtualKeyCode> GetKeys()
        {
            return buttonToKey;
        }

        public VirtualKeyCode GetKey(ButtonState button)
        {
            return buttonToKey[button];
        }
    }
}
