using CTMK.Control.State;
using System.Collections.Generic;

namespace CTMK.Control.Type
{
    public interface IController
    {
        void Update();
        List<ButtonState> GetButtonsDown();
        List<ButtonState> GetButtonsUp();
    }
}
