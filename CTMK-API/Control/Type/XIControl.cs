using CTMK_API.Control.CTState;
using CTMK_API.Utility;
using SlimDX.XInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMK_API.Control.Type
{
    public class XIControl : IController
    {
        private uint lastPacket;

        private readonly UserIndex userIndex;
        private readonly SlimDX.XInput.Controller controller;

        private PovState dPad;

        private readonly ButtonState a;
        private readonly ButtonState b;
        private readonly ButtonState x;
        private readonly ButtonState y;

        private readonly ButtonState rightShoulder;
        private readonly ButtonState leftShoulder;

        private readonly ButtonState start;
        private readonly ButtonState back;

        private readonly ButtonState leftThumbStickButton;
        private readonly ButtonState rightThumbStickButton;

        private readonly AxisState rightTrigger;
        private readonly AxisState leftTrigger;
        private AxisState leftThumbStickX;
        private AxisState leftThumbStickY;
        private AxisState rightThumbStickX;
        private AxisState rightThumbStickY;

        private readonly List<ButtonState> buttons;
        private readonly List<AxisState> axises;
        private List<string> listButtonsDown;
        private List<string> listButtonsUp;

        private readonly Dictionary<string, GamepadButtonFlags> buttonFlags;

        public XIControl(UserIndex userIndex)
        {
            this.userIndex = userIndex;
            this.controller = new SlimDX.XInput.Controller(userIndex);

            //Initialises buttonsUp and Down
            listButtonsUp = new List<string>();
            listButtonsDown = new List<string>();

            //Initialises the Axises
            axises = new List<AxisState>();

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
            leftThumbStickX = new AxisState("LX");
            leftThumbStickY = new AxisState("LY");
            rightThumbStickX = new AxisState("RX");
            rightThumbStickY = new AxisState("RY");

            //Sets up DPad
            dPad = new PovState("DPAD");

            buttons = ButtonUtil.GetListButtons(a, b, x, y, start, back, leftShoulder, rightShoulder, leftThumbStickButton, rightThumbStickButton); //,dPad.GetDown(), dPad.GetLeft(), dPad.GetRight(), dPad.GetUp());

            //Button Util PLEASE n_n
            axises.Add(leftTrigger);
            axises.Add(rightTrigger);
            axises.Add(leftThumbStickX);
            axises.Add(leftThumbStickY);
            axises.Add(rightThumbStickX);
            axises.Add(rightThumbStickY);

            buttonFlags = XInputButtonFlagLookup.ConvertButtons(buttons);
        }

        public void Update()
        {
            listButtonsUp.Clear();

            //if connected and different packet only updates when control is changed 
            //Ignore last packet as it only changes when there is a change in the controller state

            if (!Connect() || controller.GetState().PacketNumber == lastPacket) return;

            listButtonsDown.Clear();
            lastPacket = controller.GetState().PacketNumber;

            var gamepadState = controller.GetState().Gamepad;
            UpdateButtons(this.buttons, gamepadState.Buttons);

            //Sets the triggers
            UpdateAxis(leftTrigger, gamepadState.LeftTrigger);
            UpdateAxis(rightTrigger, gamepadState.RightTrigger);

            //Sets the thumbsticks
            UpdateThumbStick(ref leftThumbStickX, gamepadState.LeftThumbX);
            UpdateThumbStick(ref leftThumbStickY, gamepadState.LeftThumbY);
            UpdateThumbStick(ref rightThumbStickX, gamepadState.RightThumbX);
            UpdateThumbStick(ref rightThumbStickY, gamepadState.RightThumbY);

            UpdateButtons(dPad.GetButtons(), gamepadState.Buttons);
        }

        private void UpdateThumbStick(ref AxisState axis, short position)
        {
            axis.SetValue(ConvertPosition(position));
        }

        private ushort ConvertPosition(short position)
        {
            long temp = 32768;
            temp += position;
            return (ushort)temp;
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

        private void UpdateButtons(List<ButtonState>buttons, GamepadButtonFlags gamepadButtonFlags)
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

        public string GetName()
        {
            return "XBOX 360 Controller " + userIndex;
        }


        public int GetAxisCount()
        {
            return 6;
        }

        public int GetButtonCount()
        {
            return 10;
        }

        public int GetPovCount()
        {
            return 1;
        }


        public List<PovState> GetPovs()
        {
            var pov = new List<PovState>
            {
                dPad
            };
            return pov;
        }

        public List<ButtonState> GetButtons()
        {
            return buttons;
        }
    }
}
