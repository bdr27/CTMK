using System;
using System.Collections.Generic;
using System.Text;

namespace CTMK.Control.CTState
{
    public class AxisState
    {
        ushort axis;
        string name;

        public AxisState(string name)
        {
            this.name = name;
        }
       
        public void SetAxis(ushort axis)
        {
            this.axis = axis;
        }

        public ushort GetAxis()
        {
            return axis;
        }

        public string GetName()
        {
            return name;
        }
    }
}
