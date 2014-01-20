
using CTMK_API.Control.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace CTMK_API.Controller
{
    public class DarkForcesControlController : ControllerTemplate
    {
        public DarkForcesControlController(IController control)
            : base(control)
        {
            /*foreach (var trigger in axises)
            {
                trigger.SetActivationPoint(0.2f);
            }*/
        }

        public override void PerformActions()
        {
            foreach (var button in buttonsDown)
            {
                switch (button.ToUpper())
                {
                    case "UP":
                        Console.WriteLine("F1 Down");
                        keyboard.KeyDown(VirtualKeyCode.F1);
                        break;
                    case "DOWN":
                        Console.WriteLine("F2 Down");
                        keyboard.KeyDown(VirtualKeyCode.F2);
                        break;
                    case "LEFT":
                        Console.WriteLine("F3 Down");
                        keyboard.KeyDown(VirtualKeyCode.F3);
                        break;
                    case "RIGHT":
                        Console.WriteLine("F4 Down");
                        keyboard.KeyDown(VirtualKeyCode.F4);
                        break;
                    case "RIGHTSTICK":
                        Console.WriteLine("F5 Down");
                        keyboard.KeyDown(VirtualKeyCode.F5);
                        break;
                    case "BACK":
                        Console.WriteLine("Tab Down");
                        keyboard.KeyDown(VirtualKeyCode.TAB);
                        break;
                    case "LEFTSTICK":
                        Console.WriteLine("Shift Down");
                        keyboard.KeyDown(VirtualKeyCode.SHIFT);
                        break;
                    case "A":
                        Console.WriteLine("Spacebar Down");
                        keyboard.KeyDown(VirtualKeyCode.SPACE);
                        break;
                    case "Y":
                        Console.WriteLine("E Down");
                        keyboard.KeyDown(VirtualKeyCode.VK_E);
                        break;
                    case "X":
                        Console.WriteLine("C Down");
                        keyboard.KeyDown(VirtualKeyCode.VK_C);
                        break;
                    case "B":
                        Console.WriteLine("CapsLock Down");
                        keyboard.KeyDown(VirtualKeyCode.CAPITAL);
                        break;
                }
            }

            foreach (var button in buttonsUp)
            {
                switch (button.ToUpper())
                {
                    case "UP":
                        Console.WriteLine("F1 Up");
                        keyboard.KeyUp(VirtualKeyCode.F1);
                        break;
                    case "DOWN":
                        Console.WriteLine("F2 Up");
                        keyboard.KeyUp(VirtualKeyCode.F2);
                        break;
                    case "LEFT":
                        Console.WriteLine("F3 Up");
                        keyboard.KeyUp(VirtualKeyCode.F3);
                        break;
                    case "RIGHT":
                        Console.WriteLine("F4 Up");
                        keyboard.KeyUp(VirtualKeyCode.F4);
                        break;
                    case "RIGHTSTICK":
                        Console.WriteLine("F5 Up");
                        keyboard.KeyUp(VirtualKeyCode.F5);
                        break;
                    case "BACK":
                        Console.WriteLine("Tab Up");
                        keyboard.KeyUp(VirtualKeyCode.TAB);
                        break;
                    case "LEFTSTICK":
                        Console.WriteLine("Shift Up");
                        keyboard.KeyUp(VirtualKeyCode.SHIFT);
                        break;
                    case "A":
                        Console.WriteLine("Spacebar Up");
                        keyboard.KeyUp(VirtualKeyCode.SPACE);
                        break;
                    case "Y":
                        Console.WriteLine("E Up");
                        keyboard.KeyUp(VirtualKeyCode.VK_E);
                        break;
                    case "X":
                        Console.WriteLine("C Up");
                        keyboard.KeyUp(VirtualKeyCode.VK_C);
                        break;
                    case "B":
                        Console.WriteLine("CapsLock Up");
                        keyboard.KeyUp(VirtualKeyCode.CAPITAL);
                        break;
                }
            }
        }
    }
}
