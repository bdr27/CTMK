using CTMK_API.Control.CTState;
using SlimDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMK_API.Control.Type
{
    public class DIControl : IController
    {
        private Joystick joy;
        private int buttonCount;
        private int povCount;
        private int axisesCount;
        private List<ButtonState> buttons;
        private AxisState[] axises;
        private PovState[] povs;
        private string name;

        public DIControl(Joystick joy)
        {
            this.joy = joy;
            buttonCount = joy.Capabilities.ButtonCount;
            povCount = joy.Capabilities.PovCount;
            axisesCount = joy.Capabilities.AxesCount;
            name = joy.Information.InstanceName;
            LoadButtons();
        }
        private void LoadButtons()
        {
            buttons = new List<ButtonState>();
            for (int i = 0; i < buttonCount; i++)
            {
                buttons.Add(new ButtonState("" + (i + 1)));
            }
        }

        public bool Connect()
        {
            return (joy.Acquire().IsSuccess && joy.Poll().IsSuccess);
        }

        public void Disconnect()
        {
            joy.Unacquire();
        }

        public void Update()
        {
            JoystickState state = new JoystickState();
            //Have to check if same packet somehow
            if (joy.Poll().IsFailure)
            {
                joy.Unacquire();
                if (!Connect())
                {
                    return;
                }
            }

            if (joy.GetCurrentState(ref state).IsFailure)
            {
                joy.Unacquire();
                return;
            }

            var buttons = state.GetButtons();
            var sliders = state.GetSliders();
            var pov = state.GetPointOfViewControllers();

            Console.Clear();

            for (int i = 0; i < joy.Capabilities.PovCount; i++)
            {
                if (pov[i] != -1)
                {
                    Console.WriteLine("POV: " + (i + 1) + " " + pov[i]);
                }
            }

            for (int i = 0; i < sliders.Length; i++)
            {
                Console.WriteLine("Sliders: " + (i + 1) + " " + sliders[i]);
            }

            for (int i = 0; i < joy.Capabilities.ButtonCount; i++)
            {
                if (buttons[i])
                {
                    Console.WriteLine("Button: " + (i + 1) + " pressed");
                }
            }

            Console.WriteLine("X: " + state.X);
            Console.WriteLine("Y: " + state.Y);
            Console.WriteLine("Z: " + state.Z);
            Console.WriteLine("RX: " + state.RotationX);
            Console.WriteLine("RY: " + state.RotationY);
            Console.WriteLine("RZ: " + state.RotationZ);
        }

        public List<string> GetButtonsDown()
        {
            var down = new List<string>();
            foreach (var button in buttons)
            {
                if (button.GetDown())
                {
                    down.Add(button.GetName());
                }
            }
            return down;
        }

        public List<string> GetButtonsUp()
        {
            var up = new List<string>();
            foreach (var button in buttons)
            {
                if (button.GetReleased())
                {
                    up.Add(button.GetName());
                }
            }
            return up;
        }

        public List<AxisState> GetAxises()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return name;
        }


        public int GetAxisCount()
        {
            return axises.Count();
        }

        public int GetButtonCount()
        {
            return buttons.Count();
        }

        public int GetPovCount()
        {
            return povs.Count();
        }


        public List<PovState> GetPovs()
        {
            throw new NotImplementedException();
        }


        public List<ButtonState> GetButtons()
        {
            return buttons;
        }
    }
}
