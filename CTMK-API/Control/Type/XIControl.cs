using CTMK_API.Control.CTState;
using CTMK_API.Utility;
using SlimDX;
using SlimDX.XInput;
using System;
using System.Collections.Generic;


namespace CTMK_API.Control.Type
{
    public class XIControl : IController
    {
        private uint lastPacket;

        private readonly UserIndex userIndex;
        private readonly SlimDX.XInput.Controller controller;

        private PovState dPad;
        private ThumbstickState leftThumbStick;
        private ThumbstickState rightThumbStick;

        private ButtonState a;
        private ButtonState b;
        private ButtonState x;
        private ButtonState y;

        private ButtonState rightShoulder;
        private ButtonState leftShoulder;

        private ButtonState start;
        private ButtonState back;

        private ButtonState leftThumbStickButton;
        private ButtonState rightThumbStickButton;

        private AxisState rightTrigger;
        private AxisState leftTrigger;

        private List<ButtonState> buttons;
        private List<AxisState> axises;
        private List<string> listButtonsDown;
        private List<string> listButtonsUp;
        //private List<TriggerState> triggers;
        private List<ThumbstickState> thumbSticks;

        private Dictionary<string, GamepadButtonFlags> buttonFlags; 

        public XIControl(UserIndex userIndex)
        {
            this.userIndex = userIndex;
            this.controller = new SlimDX.XInput.Controller(userIndex);

            //Sets up face buttons
            a = new ButtonState("A");
            b = new ButtonState("B");
            x = new ButtonState("X");
            y = new ButtonState("Y");

            //Sets up the shoulder buttons
            rightShoulder = new ButtonState("RS");
            leftShoulder = new ButtonState("LS");

            leftThumbStickButton = new ButtonState("LT");
            rightThumbStickButton = new ButtonState("RT");

            //Sets up start and select
            start = new ButtonState("START");
            back = new ButtonState("BACK");

            //Sets up left and right trigger
            rightTrigger = new AxisState("RT");
            leftTrigger = new AxisState("LT");

            //Sets up DPad
            dPad = new PovState("DPAD");

            //Sets up Thumbstick
            leftThumbStick = new ThumbstickState("LEFTSTICK");
            rightThumbStick = new ThumbstickState("RIGHTSTICK");

            buttons = ButtonUtil.GetListButtons(a, b, x, y, start, back, leftShoulder, rightShoulder, leftThumbStickButton, rightThumbStickButton);

            listButtonsUp = new List<string>();
            listButtonsDown = new List<string>();
            axises = new List<AxisState>();
            thumbSticks = new List<ThumbstickState>();

            axises.Add(leftTrigger);
            axises.Add(rightTrigger);

            thumbSticks.Add(leftThumbStick);
            thumbSticks.Add(rightThumbStick);

            buttonFlags = XInputButtonFlagLookup.ConvertButtons(buttons);
        }

        public void Update()
        {
            //Clears the list to make sure no double presses
            listButtonsDown.Clear();
            listButtonsUp.Clear();

            //if connected and different packet only updates when control is changed 
            //Ignore last packet as it only changes when there is a change in the controller state

            if (!Connect()) return;
            //if (!Connect() || controller.GetState().PacketNumber == lastPacket) return;

            //lastPacket = controller.GetState().PacketNumber;

            var gamepadState = controller.GetState().Gamepad;
            UpdateButtons(gamepadState.Buttons);

            //Sets the triggers
            UpdateAxis(leftTrigger, gamepadState.LeftTrigger);
            UpdateAxis(rightTrigger, gamepadState.RightTrigger);

            //Sets the thumbsticks
            UpdateThumbStick(leftThumbStick, Normalize(gamepadState.LeftThumbX, gamepadState.LeftThumbY, Gamepad.GamepadLeftThumbDeadZone));
            UpdateThumbStick(rightThumbStick, Normalize(gamepadState.RightThumbX, gamepadState.RightThumbY, Gamepad.GamepadRightThumbDeadZone));
        }

        private void UpdateThumbStick(ThumbstickState thumbStick, Vector2 position)
        {
            thumbStick.SetPosition(position);
        }

        private Vector2 Normalize(short rawX, short rawY, short threshold)
        {
            long temp = rawX + 32768;
            ushort uRawX = (ushort)temp;
            var value = new Vector2(rawX, rawY);
            var magnitude = value.Length();
            var direction = value / (magnitude == 0 ? 1 : magnitude);

            var normalizedMagnitude = 0.0f;
            if (magnitude - threshold > 0)
                normalizedMagnitude = Math.Min((magnitude - threshold) / (short.MaxValue - threshold), 1);

            return direction * normalizedMagnitude;
        }

        private void UpdateAxis(AxisState axis, ushort value)
        {
            axis.SetValue(value);
        }

        public List<string> GetButtonsDown()
        {
            return listButtonsDown;
        }

        public List<string> GetButtonsUp()
        {
            return listButtonsUp;
        }

        public List<AxisState> GetAxises()
        {
            return axises;
        }

        public List<ThumbstickState> GetThumbSticks()
        {
            return thumbSticks;
        }

        private void UpdateButtons(GamepadButtonFlags gamepadButtonFlags)
        {
            foreach (var button in buttons)
            {
                ButtonState(button, buttonFlags[button.GetName()], gamepadButtonFlags);
            }
        }

        private void ButtonState(ButtonState buttonState, GamepadButtonFlags buttonFlag, GamepadButtonFlags buttonsDown)
        {
            if ((buttonsDown & buttonFlag) != 0)
            {
                buttonState.ButtonDown();
                listButtonsDown.Add(buttonState.GetName());
            }
            else
            {
                buttonState.ButtonUp();
                if (buttonState.GetReleased())
                {
                    listButtonsUp.Add(buttonState.GetName());
                }
            }
        }

        public bool Connect()
        {
            return controller.IsConnected;
        }

        public void Disconnect()
        {
        }
    }
}
