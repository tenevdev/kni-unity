using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Sripts.Core.Board;
using Assets.Sripts.Core.Input;
using Assets.Sripts.Components.GameManager;
using Assets.Sripts.Core.Stone;

namespace Assets.Sripts.Core.Game
{
    public class MoveGameController : GameControllerBase
    {
        private IMovable selected;

        public MoveGameController()
        {
            // TODO: Subscribe for input events which are relevant to the move stage
            //InputController.Instance.StoneSelected += OnStoneSelected;
            //InputController.Instance.DestinationSelected += OnDestinationSelected;
        }

        protected override void OnGameOver(GameOverEventArgs args)
        {
            base.OnGameOver(args);

            //TODO: Unsubscribe from input controller events
        }

        private void OnStoneSelected(IMoveStageInputController sender, StoneSelectedEventArgs args)
        {
            // TODO: Move stage state logic
            selected = args.Stone;
            throw new NotImplementedException();
        }

        private void OnDestinationSelected(IMoveStageInputController sender, PositionSelectedEventArgs args)
        {
            // TODO: Move stage state logic
            BoardController.Instance.Move(selected, args.Position);
            throw new NotImplementedException();
        }
    }
}
