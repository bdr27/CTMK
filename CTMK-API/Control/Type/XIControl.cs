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

        private DPadState dPad;
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

        private TriggerState rightTrigger;
        private TriggerState leftTrigger;

        private List<ButtonState> buttons;
        private List<string> listButtonsDown;
        private List<string> listButtonsUp;
        private List<TriggerState> triggers;
        private List<ThumbstickState> thumbSticks;

        public XIControl(UserIndex userIndex)
        {
            this.userIndex = userIndex;
            this.controller = new SlimDX.XInput.Controller(userIndex);

            //Sets up face buttons
            a = new ButtonState("A", GamepadButtonFlags.A);
            b = new ButtonState("B", GamepadButtonFlags.B);
            x = new ButtonState("X", GamepadButtonFlags.X);
            y = new ButtonState("Y", GamepadButtonFlags.Y);

            //Sets up the shoulder buttons
            rightShoulder = new ButtonState("RS", GamepadButtonFlags.RightShoulder);
            leftShoulder = new ButtonState("LS", GamepadButtonFlags.LeftShoulder);

            //Sets up start and select
            start = new ButtonState("START", GamepadButtonFlags.Start);
            back = new ButtonState("BACK", GamepadButtonFlags.Back);

            //Sets up left and right trigger
            rightTrigger = new TriggerState("RT");
            leftTrigger = new TriggerState("LT");

            //Sets up DPad
            dPad = new DPadState("DPAD");

            //Sets up Thumbstick
            leftThumbStick = new ThumbstickState("LEFTSTICK", GamepadButtonFlags.LeftThumb);
            rightThumbStick = new ThumbstickState("RIGHTSTICK", GamepadButtonFlags.RightThumb);

            buttons = ButtonUtil.GetListButtons(a, b, x, y, start, back, leftShoulder, rightShoulder, dPad.GetDown(), dPad.GetLeft(), dPad.GetRight(), dPad.GetUp(), leftThumbStick.GetButton(), rightThumbStick.GetButton());

            listButtonsUp = new List<string>();
            listButtonsDown = new List<string>();
            triggers = new List<TriggerState>();
            thumbSticks = new List<ThumbstickState>();

            triggers.Add(leftTrigger);
            triggers.Add(rightTrigger);
            thumbSticks.Add(leftThumbStick);
            thumbSticks.Add(rightThumbStick);
        }

        public void Update()
        {
            //Clears the list to make sure no double presses
            listButtonsDown.Clear();
            listButtonsUp.Clear();

            //if connected and different packet
            if (!Connect() || controller.GetState().PacketNumber == lastPacket) return;

            lastPacket = controller.GetState().PacketNumber;

            var gamepadState = controller.GetState().Gamepad;
            UpdateButtons(gamepadState.Buttons);

            //Sets the triggers
            UpdateTrigger(leftTrigger, gamepadState.LeftTrigger);
            UpdateTrigger(rightTrigger, gamepadState.RightTrigger);

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
            //ushort uRaw = rawX + 32768
            Console.WriteLine(uRawX);
            var value = new Vector2(rawX, rawY);
            var magnitude = value.Length();
            var direction = value / (magnitude == 0 ? 1 : magnitude);

            var normalizedMagnitude = 0.0f;
            if (magnitude - threshold > 0)
                normalizedMagnitude = Math.Min((magnitude - threshold) / (short.MaxValue - threshold), 1);

            return direction * normalizedMagnitude;
        }

        private void UpdateTrigger(TriggerState trigger, byte value)
        {
            trigger.SetValue(value / (float)byte.MaxValue);
        }

        public List<string> GetButtonsDown()
        {
            return listButtonsDown;
        }

        public List<string> GetButtonsUp()
        {
            return listButtonsUp;
        }

        public List<TriggerState> GetTriggers()
        {
            return triggers;
        }

        public List<ThumbstickState> GetThumbSticks()
        {
            return thumbSticks;
        }

        private void UpdateButtons(GamepadButtonFlags gamepadButtonFlags)
        {
            foreach (var button in buttons)
            {
                ButtonState(button, gamepadButtonFlags);
            }
        }

        private void ButtonState(ButtonState buttonState, GamepadButtonFlags buttonsDown)
        {
            if ((buttonsDown & buttonState.GetGamepadButtonFlags()) != 0)
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
