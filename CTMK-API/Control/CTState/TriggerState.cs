
namespace CTMK_API.Control.CTState
{
    public class TriggerState
    {
        private string name;
        private float value;
        private float activationPoint;
        private bool triggerDown;
        private bool triggerReleased;

        public TriggerState(string name)
        {
            this.name = name;
            triggerDown = false;
            triggerReleased = false;
        }

        public string GetName()
        {
            return name;
        }

        public void UpdateTriggerState()
        {
            if (value >= activationPoint)
            {
                triggerDown = true;
            }
            else if (triggerDown)
            {
                triggerDown = false;
                triggerReleased = true;
            }
        }

        public bool GetTriggerDown()
        {
            if (triggerDown)
            {
                return true;
            }
            return false;
        }

        public bool GetTriggerReleased()
        {
            if (triggerReleased)
            {
                triggerReleased = false;
                return true;
            }
            return false;
        }

        public void SetActivationPoint(float value)
        {
            this.activationPoint = value;
        }

        public void SetValue(float value)
        {
            this.value = value;
        }

        public float GetValue()
        {
            return value;
        }
    }
}
