
using CTMK_API.Control;
using CTMK_API.Control.Type;
using CTMK_API.Controller;
using System;

namespace CTMK
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = new GetControllers();
            run.Execute();
            var controllers = run.ConnectedControllers();

            ControllerTemplate ct = new MOCKController(controllers[0]);
            ct.Run();
            Console.ReadKey();
            ct.Stop();
        }
    }
}
