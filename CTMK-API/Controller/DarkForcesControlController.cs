using CTMK_API.Control.Type;
using System;
using WindowsInput.Native;

/*TODO add esc as START
Left and Right bumpers need to be used to cycle through weapons so keys from 1 to something probably 6. Will be a bit dodgy but no other solution
*/
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

            /*foreach (var stick in thumbSticks)
            {
                var dpad = stick.GetDpad();
                var left = dpad.GetLeft();
                var right = dpad.GetRight();
                var up = dpad.GetUp();
                var down = dpad.GetDown();

                switch (stick.GetName())
                {
                    case "LEFTSTICK":                 

                        #region Left-Right
                        if (stick.GetX() <= -0.2)
                        {
                            left.ButtonDown();
                            Console.WriteLine("Left Down");
                            keyboard.KeyDown(VirtualKeyCode.VK_A);
                        }
                        else
                        {

                            left.ButtonUp();
                            if (left.GetReleased())
                            {
                                Console.WriteLine("Left Up");
                                keyboard.KeyUp(VirtualKeyCode.VK_A);
                            }
                        }
                        if (stick.GetX() >= 0.2)
                        {

                            right.ButtonDown();
                            Console.WriteLine("Right Down");
                            keyboard.KeyDown(VirtualKeyCode.VK_D);
                        }
                        else
                        {
                            right.ButtonUp();
                            if (right.GetReleased())
                            {
                                Console.WriteLine("Right Up");
                                keyboard.KeyUp(VirtualKeyCode.VK_D);
                            }
                        }
                        #endregion
                        #region Up Down
                        if (stick.GetY() >= 0.2)
                        {
                            up.ButtonDown();
                            Console.WriteLine("Up Down");
                            keyboard.KeyDown(VirtualKeyCode.VK_W);
                        }
                        else
                        {
                            up.ButtonUp();
                            if (up.GetReleased())
                            {
                                Console.WriteLine("Up Up");
                                keyboard.KeyUp(VirtualKeyCode.VK_W);
                            }
                        }

                        if (stick.GetY() <= -0.2)
                        {
                            down.ButtonDown();
                            Console.WriteLine("Down Down");
                            keyboard.KeyDown(VirtualKeyCode.VK_S);
                        }
                        else
                        {
                            down.ButtonUp();
                            if (down.GetReleased())
                            {
                                Console.WriteLine("Down Up");
                                keyboard.KeyUp(VirtualKeyCode.VK_S);
                            }
                        }
                        #endregion
                        break;
                    case "RIGHTSTICK":
                        var hor = stick.GetX();
                        if (hor > -.1 && hor < .1)
                        {
                            hor = 0;
                        }

                        int x = (int)(hor * 25);
                        mouse.MoveMouseBy(x, 0);
                        if (stick.GetY() >= 0.2)
                        {
                            up.ButtonDown();
                            Console.WriteLine("Up Down");
                            keyboard.KeyDown(VirtualKeyCode.NEXT);
                        }
                        else
                        {
                            up.ButtonUp();
                            if (up.GetReleased())
                            {
                                Console.WriteLine("Up Up");
                                keyboard.KeyUp(VirtualKeyCode.NEXT);
                            }
                        }

                        if (stick.GetY() <= -0.2)
                        {
                            down.ButtonDown();
                            Console.WriteLine("Down Down");
                            keyboard.KeyDown(VirtualKeyCode.PRIOR);
                        }
                        else
                        {
                            down.ButtonUp();
                            if (down.GetReleased())
                            {
                                Console.WriteLine("Down Up");
                                keyboard.KeyUp(VirtualKeyCode.PRIOR);
                            }
                        }
                        break;
                }
            }

           /* foreach (var trigger in axises)
            {
                trigger.UpdateTriggerState();
                switch (trigger.GetName())
                {

                    case "LT":
                        if (trigger.GetTriggerDown())
                        {
                            Console.WriteLine("Right Down");
                            keyboard.KeyDown(VirtualKeyCode.VK_R);
                        }
                        else if (trigger.GetTriggerReleased())
                        {
                            Console.WriteLine("Right Up");
                            keyboard.KeyUp(VirtualKeyCode.VK_R);
                        }
                        break;
                    case "RT":
                        if (trigger.GetTriggerDown())
                        {
                            Console.WriteLine("Left Down");
                            mouse.LeftButtonDown();
                        }
                        else if (trigger.GetTriggerReleased())
                        {
                            Console.WriteLine("Left Up");
                            mouse.LeftButtonUp();
                        }
                        break;
                }
            }*/
        }
    }
}
