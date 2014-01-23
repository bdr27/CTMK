using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace CTMK_API.Control
{
    public class ControllerAction
    {
        string name;
        Dictionary <string, VirtualKeyCode> actions;

        public ControllerAction(string name)
        {
            this.name = name;
            actions = new Dictionary<string, VirtualKeyCode>();
        }

        public bool CheckKey(string button)
        {
            if (actions.ContainsKey(button))
            {
                return true;
            }
            return false;
        }

        public void AddAction(string button, VirtualKeyCode key)
        {
            if (CheckKey(button))
            {
                actions[button] = key;
            }
            else
            {
                actions.Add(button, key);
            }
        }

        public void LoadKeys(Dictionary<string, VirtualKeyCode> keys)
        {
            actions = keys;
        }

        public Dictionary<string, VirtualKeyCode> GetActions()
        {
            return actions;
        }
    }
}
