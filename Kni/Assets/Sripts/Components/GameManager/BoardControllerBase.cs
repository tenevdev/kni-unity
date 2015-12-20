using Assets.Sripts.Core.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Sripts.Core.Game;
using Assets.Sripts.Core.Input;
using Assets.Sripts.Core.Stone;

namespace Assets.Sripts.Components.GameManager
{
    public abstract class BoardControllerBase : MonoBehaviour, IBoardController
    {
        protected static BoardControllerBase instance;
        public static BoardControllerBase Instance
        {
            get
            {
                if(instance == null)
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
    }
}
