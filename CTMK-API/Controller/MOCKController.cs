using CTMK_API.Control.CTState;
using CTMK_API.Control.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMK_API.Controller
{
    public class MOCKController : ControllerTemplate
    {
        public MOCKController(IController control)
            : base(control)
        {
            /*foreach (var trigger in axises)
            {
                trigger.SetActivationPoint(0.2f);
            }*/
        }

        public override void PerformActions()
        {
            LoopThrough("Button Up", buttonsUp);
            LoopThrough("Button Down", buttonsDown);
            LoopThrough(axises);
        }

        private void LoopThrough(string message, List<string> items)
        {
            foreach (var item in items)
            {
                PrintMessage(message, item);
            }
        }

        private void LoopThrough(List<AxisState> items)
        {

            foreach (var item in items)
            {
                PrintMessage(item.GetName() + ": ", "" + item.GetValue());
            }
        }

        private void PrintMessage(string message, string value)
        {
            Console.WriteLine(message + ": " + value);
        }
    }
}
