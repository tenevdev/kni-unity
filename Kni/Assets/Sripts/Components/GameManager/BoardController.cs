using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Sripts.Core.Input;
using UnityEngine;
using System.Collections;
using Assets.Sripts.Core.Game;
using Assets.Sripts.Core.Stone;

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
    }
}
