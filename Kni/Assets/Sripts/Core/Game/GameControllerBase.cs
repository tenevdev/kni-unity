using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Sripts.Core.Input;
using Assets.Sripts.Core.Board;

namespace Assets.Sripts.Core.Game
{
    public abstract class GameControllerBase : IGameController
    {
        public Player CurrentPlayer { get; set; }

        public virtual void ExecuteMove()
        {
            throw new NotImplementedException();
        }

        public void UpdateCurrentPlayer()
        {
            if(CurrentPlayer == Player.Black)
            {
                CurrentPlayer = Player.White;
            } else
            {
                CurrentPlayer = Player.Black;
            }
        }

        public event SetupCompleteEventHandler SetupComplete;
        protected virtual void OnSetupComplete()
        {
            if (SetupComplete != null)
            {
                SetupComplete(this, EventArgs.Empty);
            }
        }

        public event GameOverEventHandler GameOver;
        protected virtual void OnGameOver(GameOverEventArgs args)
        {
            if (GameOver != null)
            {
                GameOver(this, args);
            }
        }
    }
}
