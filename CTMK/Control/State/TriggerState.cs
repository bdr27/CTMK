
namespace CTMK.Control.State
{
    public class TriggerState
    {
        private string name;
        private float value;

        public TriggerState(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
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
