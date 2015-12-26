using System;
using UnityEngine;
using Assets.Sripts.Core.Game;
using Assets.Sripts.Core.Stone;
using Assets.Sripts.Core.Board;
using System.Collections.Generic;

namespace Assets.Sripts.Components.GameManager
{
    public abstract class BoardControllerBase : MonoBehaviour, IBoardController
    {
        protected static BoardControllerBase instance;
        public static BoardControllerBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = GameObject.FindObjectOfType<BoardControllerBase>();
                }
                return instance;
            }
        }


        private CellState[,] board;

        public int boardSize;

        public virtual void Start()
        {
            this.board = new CellState[boardSize, boardSize];
        }

        public virtual void Move(IMovable stone, Vector3 destination)
        {
            // TODO: Update only the state of the CellState matrix
            throw new NotImplementedException();
        }

        public virtual void Insert(Vector3 position, Player player)
        {
            // TODO: Update only the state of the CellState matrix
            throw new NotImplementedException();
        }


        //Setup logic validation

        // This method should probably be split into several others as it is quite complicated
        // And should definitely be not recursive
        private bool CheckForSquaresContaining(int nextCellToConsider, List<CellCoordinates> stones, CellCoordinates[] toCheck, int numberOfStones)
        {
            //post: returns if a stone of the player can be placed in cell (i, j)
            //the cell's coordinates where added to toCheck when calling the function

            if (numberOfStones > 1)
            {
                //if n elements of toCheck are in a n * n square
                //way to do it is: get maxX, minX, maxY, minY coordinates
                //check if the rectangle they form is at most n * n
                //in that case return false

                int minX, maxX, minY, maxY;
                minX = maxX = toCheck[0].X;
                minY = maxY = toCheck[0].Y;

                for (int i = 1; i < toCheck.Length; i++)
                {
                    minX = (toCheck[i].X < minX) ? toCheck[i].X : minX;
                    maxX = (toCheck[i].X > maxX) ? toCheck[i].X : maxX;
                    minY = (toCheck[i].Y < minY) ? toCheck[i].Y : minY;
                    maxY = (toCheck[i].Y > maxY) ? toCheck[i].Y : maxY;
                }

                int height = maxY - minY + 1;
                int width = maxX - minX + 1;
                if (height <= numberOfStones && width <= numberOfStones)
                    return false;
            }

            for (int i = nextCellToConsider; i < stones.Count; i++)
            {
                toCheck[numberOfStones].setToCoordinates(stones[i]);
                if (!CheckForSquaresContaining(i + 1, stones, toCheck, numberOfStones + 1))
                    return false;
            }
            return true;

        }

        public bool[,] PossiblePositions(Player player)
        {

            int width = board.GetLength(0);
            int height = board.GetLength(1);

            List<CellCoordinates> stones = new List<CellCoordinates>(); //stones of player's color
            bool[,] canBePlaced = new bool[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {

                    canBePlaced[i, j] = false;
                    if (board[i, j] != CellState.Empty)
                    {
                        continue;
                    }

                    if ((int)board[i, j] == (int)player)
                    {
                        stones.Add(new CellCoordinates(i, j));
                    }
                    else if (board[i, j] == CellState.Empty)
                    {
                        canBePlaced[i, j] = true;
                    }
                }
            }

            //will store stones which are checked if they belong to the same square
            CellCoordinates[] toCheck = new CellCoordinates[stones.Count + 1];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (canBePlaced[i, j])
                    {
                        toCheck[0].X = i;
                        toCheck[0].Y = j;

                        canBePlaced[i, j] = CheckForSquaresContaining(0, stones, toCheck, 1);
                    }

                }
            }

            return canBePlaced;
        }
    }
}
