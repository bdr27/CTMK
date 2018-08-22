
using CTMK_API.Control.Type;
using CTMK_API.Utility;
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
        private readonly float activationPoint = 0.2f;
        private readonly bool[] simpleActivation;
        private int weapon = 0;
        private long milliseconds;
        private readonly int weaponTimer = 150;
        private readonly int mouseSpeed = 25;

        public DarkForcesControlController(IController control)
            : base(control)
        {
            var amount = control.GetAxises().Count * 2;
            simpleActivation = new bool[amount];            
            milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }

        private void ButtonsDown()
        {
            foreach (var button in buttonsDown)
            {
                long temp;
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
                    case "RT":
                        Console.WriteLine("F5 Down");
                        keyboard.KeyDown(VirtualKeyCode.F5);
                        break;
                    case "BACK":
                        Console.WriteLine("Tab Down");
                        keyboard.KeyDown(VirtualKeyCode.TAB);
                        break;
                    case "LT":
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
                    case "START":
                        Console.WriteLine("ESCAPE");
                        keyboard.KeyDown(VirtualKeyCode.ESCAPE);
                        break;
                    case "RS":
                        temp = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                        if (temp - milliseconds > weaponTimer)
                        {
                            milliseconds = temp;
                            if (weapon != 9)
                            {
                                weapon++;
                            }
                            else
                            {
                                weapon = 0;
                            }
                            Console.WriteLine(weapon);
                            var key = ButtonUtil.KeyToVirtualKey("D" + weapon);
                            keyboard.KeyPress(key);
                        }
                        break;
                    case "LS":
                        temp = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                        if (temp - milliseconds > weaponTimer)
                        {
                            if (weapon != 0)
                            {
                                weapon--;
                            }
                            else
                            {
                                weapon = 9;
                            }
                            milliseconds = temp;
                            Console.WriteLine(weapon);
                            var key = ButtonUtil.KeyToVirtualKey("D" + weapon);
                            keyboard.KeyPress(key);
                        }
                        break;

                }
            }
        }

        private void ButtonsUp()
        {
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
                    case "RT":
                        Console.WriteLine("F5 Up");
                        keyboard.KeyUp(VirtualKeyCode.F5);
                        break;
                    case "BACK":
                        Console.WriteLine("Tab Up");
                        keyboard.KeyUp(VirtualKeyCode.TAB);
                        break;
                    case "LT":
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
                    case "START":
                        Console.WriteLine("ESCAPE");
                        keyboard.KeyUp(VirtualKeyCode.ESCAPE);
                        break;
                }
            }
        }

        private void Axises()
        {

            foreach (var axis in axises)
            {
                float difference = 0;
                if (axis.GetCalibration() < 500)
                {
                    difference = axis.GetValue() / 255;
                }
                else
                {
                    difference = ((float)axis.GetValue() - (float)axis.GetCalibration()) / (float)axis.GetCalibration();
                }
                switch (axis.GetName().ToUpper())
                {
                    case "LX":
                        if (difference < -activationPoint)
                        {
                            simpleActivation[0] = true;
                            keyboard.KeyDown(VirtualKeyCode.VK_A);
                            Console.WriteLine("A Down");
                        }
                        else if (simpleActivation[0])
                        {
                            simpleActivation[0] = false;
                            keyboard.KeyUp(VirtualKeyCode.VK_A);
                            Console.WriteLine("A Up");
                        }
                        if (difference > activationPoint)
                        {
                            simpleActivation[1] = true;
                            keyboard.KeyDown(VirtualKeyCode.VK_D);
                            Console.WriteLine("D Down");
                        }
                        else if (simpleActivation[1])
                        {
                            simpleActivation[1] = false;
                            keyboard.KeyUp(VirtualKeyCode.VK_D);
                            Console.WriteLine("D Up");
                        }
                        break;
                    case "LY":
                        if (difference < -activationPoint)
                        {
                            simpleActivation[2] = true;
                            keyboard.KeyDown(VirtualKeyCode.VK_S);
                            Console.WriteLine("S Down");
                        }
                        else if (simpleActivation[2])
                        {
                            simpleActivation[2] = false;
                            keyboard.KeyUp(VirtualKeyCode.VK_S);
                            Console.WriteLine("S Up");
                        }
                        if (difference > activationPoint)
                        {
                            simpleActivation[3] = true;
                            keyboard.KeyDown(VirtualKeyCode.VK_W);
                            Console.WriteLine("W Down");
                        }
                        else if (simpleActivation[3])
                        {
                            simpleActivation[3] = false;
                            keyboard.KeyUp(VirtualKeyCode.VK_W);
                            Console.WriteLine("W Up");
                        }
                        break;
                    case "RX":
                        if (difference > activationPoint || difference < -activationPoint)
                        {
                            mouse.MoveMouseBy((int)(difference * mouseSpeed), 0);
                        }
                        break;
                    case "RY":
                        if (difference > activationPoint || difference < -activationPoint)
                        {
                            mouse.MoveMouseBy(0, (int)-(difference * mouseSpeed));
                        }
                        if (difference > activationPoint)
                        {
                            simpleActivation[6] = true;
                            keyboard.KeyDown(VirtualKeyCode.NEXT);
                            Console.WriteLine("Page Down Down");
                        }
                        else if(simpleActivation[6])
                        {
                            simpleActivation[6] = false;
                            Console.WriteLine("Page Down Up");
                            keyboard.KeyUp(VirtualKeyCode.NEXT);
                        }

                        if (difference < -activationPoint)
                        {
                            simpleActivation[7] = true;
                            keyboard.KeyDown(VirtualKeyCode.PRIOR);
                            Console.WriteLine("Page Up Down");
                        }
                        else if(simpleActivation[7])
                        {
                            simpleActivation[7] = false;
                            Console.WriteLine("Page Up Up");
                            keyboard.KeyUp(VirtualKeyCode.PRIOR);
                        }
                        break;
                    case "LT":
                        if (difference > activationPoint)
                        {
                            if (!simpleActivation[4])
                            {
                                simpleActivation[4] = true;
                                mouse.RightButtonDown();
                            }
                        }
                        else if (simpleActivation[4])
                        {
                            mouse.RightButtonUp();
                            simpleActivation[4] = false;
                        }
                        break;
                    case "RT":
                        if (difference > activationPoint)
                        {
                            if (!simpleActivation[5])
                            {
                                mouse.LeftButtonDown();
                                simpleActivation[5] = true;
                            }
                        }
                        else if (simpleActivation[5])
                        {
                            mouse.LeftButtonUp();
                            simpleActivation[5] = false;
                        }
                        break;
                }
            }
        }

        public override void PerformActions()
        {
            Axises();
            ButtonsDown();
            ButtonsUp();
        }
    }
}
