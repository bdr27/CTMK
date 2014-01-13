﻿using CTMK_API.Control.CTState;
using SlimDX.DirectInput;
using System;
using System.Collections.Generic;

namespace CTMK_API.Control.Type
{
    public class DIControl : IController
    {
        private Joystick joy;
        private ButtonState[] buttons;
        private TriggerState[] axis;
        private DPadState[] pov;

        public DIControl(Joystick joy)
        {
            this.joy = joy;
            buttons = new ButtonState[joy.Capabilities.ButtonCount];
            axis = new TriggerState[joy.Capabilities.AxesCount];
            pov = new DPadState[joy.Capabilities.PovCount];
        }

        public bool Connect()
        {
            return (joy.Acquire().IsSuccess && joy.Poll().IsSuccess);
        }

        public void Disconnect()
        {
            joy.Unacquire();
        }

        public void Update()
        {
            JoystickState state = new JoystickState();

            //Have to check if same packet somehow
            if (joy.Poll().IsFailure)
            {
                joy.Unacquire();
                if (!Connect())
                {
                    return;
                }
            }

            if (joy.GetCurrentState(ref state).IsFailure)
            {
                joy.Unacquire();
                return;
            }

            var buttons = state.GetButtons();
            var sliders = state.GetSliders();
            var pov = state.GetPointOfViewControllers();

            Console.Clear();

            for (int i = 0; i < joy.Capabilities.PovCount; i++)
            {
                if (pov[i] != -1)
                {
                    Console.WriteLine("POV: " + (i + 1) + " " + pov[i]);
                }
            }

            for (int i = 0; i < sliders.Length; i++)
            {
                Console.WriteLine("Sliders: " + (i + 1) +  " " + sliders[i]);
            }

            for (int i = 0; i < joy.Capabilities.ButtonCount; i++)
            {
                if (buttons[i])
                {
                    Console.WriteLine("Button: " + (i + 1) + " pressed");
                }
            }

            Console.WriteLine("X: " + state.X);
            Console.WriteLine("Y: " + state.Y);
            Console.WriteLine("Z: " + state.Z);
            Console.WriteLine("RX: " + state.RotationX);
            Console.WriteLine("RY: " + state.RotationY);
            Console.WriteLine("RZ: " + state.RotationZ);
        }

        public List<string> GetButtonsDown()
        {
            var down = new List<string>();
            foreach (var button in buttons)
            {
                if (button.GetDown())
                {
                    down.Add(button.GetName());
                }
            }
            return down;
        }

        public List<string> GetButtonsUp()
        {
            var up = new List<string>();
            foreach (var button in buttons)
            {
                if (button.GetReleased())
                {
                    up.Add(button.GetName());
                }
            }
            return up;
        }

        public List<TriggerState> GetTriggers()
        {
            throw new NotImplementedException();
        }

        public List<ThumbstickState> GetThumbSticks()
        {
            throw new NotImplementedException();
        }
    }
}