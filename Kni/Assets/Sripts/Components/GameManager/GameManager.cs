using Assets.Sripts.Components.UserInput;
using Assets.Sripts.Core.Game;
using Assets.Sripts.Core.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Sripts.Components.GameManager
{
    public class GameManager : MonoBehaviour
    {
        public InputController inputController;
        public BoardController boardController;

        public GameControllerBase GameController { get; set; }
        public bool IsOver { get; set; }

        public void Start()
        {
            GameController = new SetupGameController();
            GameController.SetupComplete += OnSetupOver;
        }

        private void OnSetupOver(IGameController sender, EventArgs args)
        {
            // TODO: Change to move game controller
            // Subscribe for game over event on it
        }

        private void OnGameOver(IGameController sender, GameOverEventArgs args)
        {
        }
    }
}