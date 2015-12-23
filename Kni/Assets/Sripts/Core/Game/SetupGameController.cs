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

		//Setup logic
		public bool checkForSquaresContaining(int i, int j, List<CellCoordinates> stones)
		{
			//post: returns if a stone of the player can be placed in cell (i, j) 
			//TODO
			int totalStonesOfPlayer = 0;
			
			return false;
		}
		
		public bool[,] PossiblePositions(CellState[,] board, Player player)
		{
			
			int width = board.GetLength (0);
			int height = board.GetLength (1);
			
			List<CellCoordinates> stones = new List<CellCoordinates> (); //stones of same color
			bool[,] canBePlaced = new bool[width, height];
			
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < height; j++) {
					
					if((int)board[i, j] != 2) // Empty
					{
						canBePlaced[i, j] = false;
						continue;
					}
					canBePlaced[i, j] = false;
					if((int)board[i, j] == (int)player)
					{
						stones.Add(new CellCoordinates(i, j));
					}
					else if((int)board[i, j] == 2) //empty
					{
						canBePlaced[i, j] = true;
					}
					
				}
			}
			
			for (int i = 0; i < width; i++)
			{
				for(int j = 0; j < width; j++)
				{
					if(canBePlaced[i,j])
						canBePlaced[i, j] 
						= checkForSquaresContaining(i, j, stones);
				}
			}
			
			return canBePlaced;
		}

    }
}
