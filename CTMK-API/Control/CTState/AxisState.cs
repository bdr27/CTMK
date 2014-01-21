using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMK_API.Control.CTState
{
    public class AxisState
    {
        private bool calibrate = false;
        private ushort middle;
        private ushort min;
        private ushort max;
        private ushort value;
        private ushort calibration;
        private string name;

        public AxisState(string name)
        {
            this.name = name;
        }

        public void SetValue(ushort value)
        {
            if (!calibrate)
            {
                calibrate = true;
                min = value;
                max = value;
                middle = value;
                calibration = value;
            }
            else
            {
                if (value < min)
                {
                    min = value;
                    middle = CalculateMidddle(min, max);
                }
                if (value > max)
                {
                    max = value;
                    middle = CalculateMidddle(min, max);
                }
            }
            this.value = value;
        }

        private ushort CalculateMidddle(ushort low, ushort high)
        {
            return (ushort)(min + ((max - min) / 2));
        }

        public ushort GetValue()
        {
            return value;
        }

        public ushort GetMinValue()
        {
            return min;
        }

        public ushort GetMaxValue()
        {
            return max;
        }

        public ushort GetMiddle()
        {
            return middle;
        }

        public string GetName()
        {
            return name;
        }

        public ushort GetCalibration()
        {
            return calibration;
        }
    }
}
