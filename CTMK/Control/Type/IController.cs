using CTMK.Control.CTState;
using System.Collections.Generic;

namespace CTMK.Control.Type
{
    public interface IController
    {
        void Update();
        List<string> GetButtonsDown();
        List<string> GetButtonsUp();
        List<TriggerState> GetTriggers();
        List<ThumbstickState> GetThumbSticks();
        bool Connected();
    }
}
