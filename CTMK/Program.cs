
using CTMK_API.Control.Type;
using CTMK_API.Controller;
using SlimDX.DirectInput;
using SlimDX.XInput;
using System;
using System.Collections.Generic;

namespace CTMK
{
    class Program
    {
        static void Main(string[] args)
        {
            //XInputTest();
            var sticks = Avaliable();
            var joy = sticks[0];
            Aquire(joy);
            IController di = new DIControl(joy);
            if(di.Connect())
            {
                while (true)
                {
                    di.Update();
                    System.Threading.Thread.Sleep(1);
                }
            }
            /*while (true)
            {
                Poll(joy);
                System.Threading.Thread.Sleep(1);
            }*/
            Console.ReadKey();
            /* IController control = new XIControl(UserIndex.One);
            ControllerTemplate ct = new DarkForcesControlController(control);
            ct.Run();
            var input = "";
            do
            {
                Console.WriteLine("Please enter q to quit");
                input = Console.ReadLine().ToLower();
            } while (input != "q");
            ct.Stop();
            while (true)
            {
                control.Update();
                var down = control.GetButtonsDown();
                var up = control.GetButtonsUp();
                if (down.Count > 0)
                {
                    Console.Write("DOWN: ");
                    foreach (var btn in down)
                    {
                        Console.Write(btn + ", ");
                    }
                    Console.WriteLine();
                }
                if (up.Count > 0)
                {
                    Console.Write("UP: ");
                    foreach (var btn in up)
                    {
                        Console.Write(btn + ", ");
                    }
                    Console.WriteLine();
                }
                var left = control.GetThumbSticks()[0];
                var right = control.GetThumbSticks()[1];
                Console.WriteLine("Left: " + left.GetX() + "," + left.GetY() + " Right: " + right.GetX() + "," + right.GetY());

                var lt = control.GetTriggers()[0];
                var rt = control.GetTriggers()[1];
                Console.WriteLine("LT: " + lt.GetValue() + " RT: " + rt.GetValue());

                System.Threading.Thread.Sleep(1);
            }*/
        }



        private static void DirectInputTest1()
        {
            List<Joystick> joysticks = new List<Joystick>();
            JoystickState state = new JoystickState();
            DirectInput dinput = new DirectInput();
            var count = 0;

            foreach (DeviceInstance device in dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                try
                {
                    //if (count == 0)
                    //{
                    joysticks.Add(new Joystick(dinput, device.InstanceGuid));
                    //}

                    //count = 1;
                    //break;
                }

                catch (DirectInputException)
                {
                }
            }

            //foreach(var joy in joysticks)

            var joy = joysticks[2];
            if (joy.Acquire().IsFailure || joy.Poll().IsFailure)
            {

            }
            else
            {
                JoystickState js = new JoystickState();
                joy.GetCurrentState(ref js);
                var pov = js.GetPointOfViewControllers();
                var buttons = js.GetButtons();
                var axis = js.GetSliders();
                Console.WriteLine(joy.Information.InstanceName);
            }
        }

        private static IList<Joystick> Avaliable()
        {
            IList<Joystick> result = new List<Joystick>();
            DirectInput dinput = new DirectInput();
            foreach (DeviceInstance di in dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                Joystick dev = new Joystick(dinput, di.InstanceGuid);
                result.Add(dev);
            }
            return result;
        }

        private static void Aquire(Joystick joy)
        {

            joy.Properties.AxisMode = DeviceAxisMode.Absolute;
            joy.Acquire();
        }

        private static void Poll(Joystick joy)
        {
            JoystickState state = new JoystickState();

            if (joy.Poll().IsFailure)
            {
                joy.Unacquire();
                return;
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
                Console.WriteLine("Sliders: " + (i + 1) + sliders[i]);
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
        }

        private static void XInputTest()
        {
            IController control = new XIControl(UserIndex.One);
            ControllerTemplate ct = new DarkForcesControlController(control);
            ct.Run();
            var input = "";
            do
            {
                Console.WriteLine("Please enter q to quit");
                input = Console.ReadLine().ToLower();
            } while (input != "q");
            ct.Stop();
        }
    }
}
