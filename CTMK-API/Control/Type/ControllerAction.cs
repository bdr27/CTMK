using CTMK_API.Control.CTState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace CTMK_API.Control.Type
{
    public class ControllerAction
    {
        Dictionary<string, VirtualKeyCode> actionButton;
        Dictionary<string, AxisState> actionAxis;

        public ControllerAction()
        {
        }
    }
}
