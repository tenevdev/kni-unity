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
		public bool checkForSquaresContaining(int nextCellToConsider, List<CellCoordinates> stones, CellCoordinates[] toCheck, int numberStones)
		{
			//post: returns if a stone of the player can be placed in cell (i, j)
			//the cell's coordinates where added to toCheck when calling the function

			bool canPlace = true;
			if(numberStones > 1) {
				//if n elements of toCheck are in a n * n square
				;
			}

			for (int i = nextCellToConsider; i < stones.Count; i++) 
			{
				toCheck[numberStones].setToCoordinates(stones[i]);
				canPlace &= checkForSquaresContaining(i + 1, stones, toCheck, numberStones + 1);
			}
			return canPlace;

		}
		
		public bool[,] PossiblePositions(CellState[,] board, Player player)
		{
			
			int width = board.GetLength (0);
			int height = board.GetLength (1);
			
			List<CellCoordinates> stones = new List<CellCoordinates> (); //stones of player's color
			bool[,] canBePlaced = new bool[width, height];
			
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++) 
				{

					canBePlaced[i, j] = false;
					if((int)board[i, j] != 2) // Empty
					{
						continue;
					}

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

			//will store stones which are checked if they belong to the same square
			CellCoordinates[] toCheck = new CellCoordinates[stones.Count + 1];

			for (int i = 0; i < width; i++)
			{
				for(int j = 0; j < height; j++)
				{
					if(canBePlaced[i, j])
					{
						toCheck[0].setXY(i, j);
						canBePlaced[i, j] 
						= checkForSquaresContaining(0, stones, toCheck, 1);
					}
						
				}
			}
			
			return canBePlaced;
		}

    }
}
