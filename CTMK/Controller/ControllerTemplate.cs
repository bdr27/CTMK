using CTMK.Control.CTState;
using CTMK.Control.Type;
using System;
using System.Collections.Generic;
using System.Timers;
using WindowsInput;

namespace CTMK.Controller
{
    public abstract class ControllerTemplate
    {
        private Timer timer;
        private IController control;
        protected List<string> buttonsDown;
        protected List<string> buttonsUp;
        protected List<ThumbstickState> thumbSticks;
        protected List<TriggerState> triggers;
        protected IKeyboardSimulator keyboard;
        protected IMouseSimulator mouse;

        public ControllerTemplate(IController control)
        {
            this.control = control;
            thumbSticks = control.GetThumbSticks();
            triggers = control.GetTriggers();
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
            thumbSticks = control.GetThumbSticks();
            triggers = control.GetTriggers();
            PerformActions();
        }

        private void SetupTimer()
        {
            timer = new Timer(1);
            timer.Elapsed += new ElapsedEventHandler(Timer_Tick);
        }
    }
}
