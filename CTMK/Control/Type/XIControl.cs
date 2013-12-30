using CTMK.Control.State;
using CTMK.Utility;
using SlimDX.XInput;
using System;
using System.Collections.Generic;


namespace CTMK.Control.Type
{
    public class XIControl : IController
    {
        private readonly UserIndex userIndex;
        private readonly Controller controller;

        private DPadState dPad;
        private ThumbstickState leftStick;
        private ThumbstickState rightStick;

        private ButtonState a;
        private ButtonState b;
        private ButtonState x;
        private ButtonState y;

        private ButtonState rightShoulder;
        private ButtonState leftShoulder;

        private ButtonState start;
        private ButtonState back;

        private TriggerState rightTrigger;
        private TriggerState leftTrigger;

        private List<ButtonState> buttons;

        public XIControl(UserIndex userIndex)
        {
            this.userIndex = userIndex;
            this.controller = new Controller(userIndex);

            //Sets up face buttons
            a = new ButtonState("A");
            b = new ButtonState("B");
            x = new ButtonState("X");
            y = new ButtonState("Y");

            //Sets up the shoulder buttons
            rightShoulder = new ButtonState("RS");
            leftShoulder = new ButtonState("LS");

            //Sets up start and select
            start = new ButtonState("START");
            back = new ButtonState("BACK");

            //Sets up left and right trigger
            rightTrigger = new TriggerState("RT");
            leftTrigger = new TriggerState("LT");

            //Sets up DPad
            dPad = new DPadState("DPAD");

            //Sets up Thumbstick
            leftStick = new ThumbstickState("LEFTSTICK");
            rightStick = new ThumbstickState("RIGHTSTICK");

            buttons = ButtonUtil.GetListButtons(a, b, x, y, start, back, leftShoulder, rightShoulder, dPad.GetDown(), dPad.GetLeft(), dPad.GetRight(), dPad.GetUp(), leftStick.GetButton(), rightStick.GetButton());
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public List<ButtonState> GetButtonsDown()
        {
            throw new NotImplementedException();
        }

        public List<ButtonState> GetButtonsUp()
        {
            throw new NotImplementedException();
        }
    }
}
