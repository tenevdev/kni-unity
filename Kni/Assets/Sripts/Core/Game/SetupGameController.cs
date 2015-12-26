using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Sripts.Core.Input;
using Assets.Sripts.Components.UserInput;
using Assets.Sripts.Components.GameManager;
using Assets.Sripts.Core.Board;

namespace Assets.Sripts.Core.Game
{
    public class SetupGameController : GameControllerBase
    {
        public SetupGameController()
        {
            // TODO: Subscribe for input events which are relevant to the setup stage
            InputController.Instance.PositionSelected += OnPositionSelected;
        }

        protected override void OnSetupComplete()
        {
            base.OnSetupComplete();

            // TODO: Unsubscribe from input controller events
        }

        private void OnPositionSelected(ISetupStageInputController sender, PositionSelectedEventArgs args)
        {
            // TODO: Setup stage state logic
            BoardController.Instance.Insert(args.Position, CurrentPlayer);
            throw new NotImplementedException();
        }
    }
}
