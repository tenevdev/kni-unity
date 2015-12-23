using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Sripts.Core.Input;
using UnityEngine;
using System.Collections;
using Assets.Sripts.Core.Game;
using Assets.Sripts.Core.Stone;
using Assets.Sripts.Core.Board;

namespace Assets.Sripts.Components.GameManager
{
    public class BoardController : BoardControllerBase
    {
        public GameObject stonePrefab;

        public override void Move(IMovable stone, Vector3 destination)
        {
            base.Move(stone, destination);

            // TODO: Use stone movement controller to invoke the stone actual movement
            //stone.Move(destination);
        }

        public override void Insert(Vector3 position, Player player)
        {
            base.Insert(position, player);
            
            // TODO: Initialise stone game object at the given position using the prefab field
        }

		//Setup logic
		public bool checkForSquaresContaining(int i, int j, CellState[,] board, Player player, int dimensions)
		{
			//post: returns if a stone of the player can be placed in cell (i, j) 
			int totalStonesOfPlayer = 0;
			for(int dimension = 2; dimension <= dimensions; dimension++)
			{
				//TODO, check squares around
			}
			return false;
		}

		public bool[,] PossiblePositions(CellState[,] board, Player player)
		{

			int width = board.GetLength (0);
			int height = board.GetLength (1);
		
			bool[,] canBePlaced = new bool[width, height];
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < height; j++) {

					if((int)board[i, j] != 2) // Empty
					{
						canBePlaced[i, j] = false;
						continue;
					}
					
					canBePlaced[i, j] 
						= checkForSquaresContaining(i, j, board, player, Math.Min(width, height));
				}
			}
			return canBePlaced;
		}
    }
}
