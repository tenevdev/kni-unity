using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Sripts.Core.Game
{
    public interface IGameController
    {
        void ExecuteMove();
        void UpdateCurrentPlayer();
    }

    public delegate void GameOverEventHandler(IGameController sender, GameOverEventArgs args);
    public delegate void SetupCompleteEventHandler(IGameController sender, EventArgs args);

}
