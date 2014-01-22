using CTMK_API.Control.CTState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        int GetAxisCount();
        int GetButtonCount();
        int GetPovCount();
        string GetName();
    }
}
