using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Sripts.Core.Input
{
    public interface ISetupStageInputController
    {
        event PositionSelectedEventHandler PositionSelected;
    }

    public delegate void PositionSelectedEventHandler(ISetupStageInputController sender, PositionSelectedEventArgs args);
}
