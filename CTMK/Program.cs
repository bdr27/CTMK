
using CTMK_API.Control;
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

            Console.ReadKey();         
        }
    }
}
