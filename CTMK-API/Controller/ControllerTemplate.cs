using CTMK_API.Control.CTState;
using CTMK_API.Control.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WindowsInput;

namespace CTMK_API.Controller
{
    public abstract class ControllerTemplate
    {
        private Timer timer;
        private IController control;
        protected List<string> buttonsDown;
        protected List<string> buttonsUp;
        protected List<AxisState> axises;
        protected IKeyboardSimulator keyboard;
        protected IMouseSimulator mouse;

        public ControllerTemplate(IController control)
        {
            this.control = control;
            axises = control.GetAxises();
            keyboard = new InputSimulator().Keyboard;
            mouse = new InputSimulator().Mouse;
            SetupTimer();
        }

        public void Run()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public abstract void PerformActions();

        private void Timer_Tick(object sender, ElapsedEventArgs e)
        {
            control.Update();
            buttonsDown = control.GetButtonsDown();
            buttonsUp = control.GetButtonsUp();
            axises = control.GetAxises();
            PerformActions();
        }

        private void SetupTimer()
        {
            timer = new Timer(1);
            timer.Elapsed += new ElapsedEventHandler(Timer_Tick);
        }
    }
}
