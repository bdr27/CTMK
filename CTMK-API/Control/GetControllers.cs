using CTMK_API.Control.Type;
using SlimDX.DirectInput;
using SlimDX.XInput;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTMK_API.Control
{
    public class GetControllers : IExecute
    {
        private List<IController> controllers;

        public GetControllers()
        {
            controllers = new List<IController>();
        }

        public void Execute()
        {
            DirectInput dinput = new DirectInput();
            var devices = GetDevices(dinput);
            var xinput = false;

            foreach (var device in devices)
            {
                try
                {
                    var control = new Joystick(dinput, device.InstanceGuid);
                    if (control.Information.InstanceName.Contains("XBOX 360"))
                    {
                        if (!xinput)
                        {
                            var xInputList = GetXinputControls();
                            foreach (var xi in xInputList)
                            {
                                controllers.Add(xi);
                            }
                            xinput = true;
                        }
                    }
                    else
                    {
                        controllers.Add(new DIControl(control));
                        Console.WriteLine("Loaded: " + control.Information.InstanceName);
                    }
                    
                }
                catch (DirectInputException ex)
                {
                    Console.WriteLine("Error trying to connect to: " + ex.Message);
                }                
            }
        }

        private List<XIControl> GetXinputControls()
        {
            var xiControls = new List<XIControl>();
            for (int i = 0; i < 4; i++)
            {
                var xiControl = new XIControl((UserIndex)i);
                if (xiControl.Connect())
                {
                    xiControls.Add(xiControl);
                    Console.WriteLine("Loaded: 360 Control " + (UserIndex)i);
                }
            }
            return xiControls;
        }

        public List<IController> ConnectedControllers()
        {
            return controllers;
        }

        private IList<DeviceInstance> GetDevices(DirectInput dinput)
        {
            return dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly);
        }
    }
}
