using CTMK.Control.CTState;
using System.Collections.Generic;

namespace CTMK.Control.Type
{
    public interface IController
    {
        bool Connect();
        void Disconnect();
        void Update();
        List<string> GetButtonsDown();
        List<string> GetButtonsUp();
        List<TriggerState> GetTriggers();
        List<ThumbstickState> GetThumbSticks();
    }
}
