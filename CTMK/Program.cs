
using CTMK.Control.Type;
using SlimDX.XInput;
using System;
namespace CTMK
{
    class Program
    {
        static void Main(string[] args)
        {
            IController control = new XIControl(UserIndex.One);
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
            }
        }
    }
}
