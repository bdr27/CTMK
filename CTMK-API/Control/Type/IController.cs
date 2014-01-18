using CTMK_API.Control.CTState;
using System.Collections.Generic;

namespace CTMK_API.Control.Type
{
    public interface IController
    {
        bool Connect();
        void Disconnect();
        void Update();
        List<string> GetButtonsDown();
        List<string> GetButtonsUp();
        List<AxisState> GetAxises();
    }
}
