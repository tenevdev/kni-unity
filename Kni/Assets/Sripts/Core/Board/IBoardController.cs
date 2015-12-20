using Assets.Sripts.Core.Game;
using Assets.Sripts.Core.Stone;
using UnityEngine;

namespace Assets.Sripts.Core.Board
{
    public interface IBoardController
    {
        void Move(IMovable stone, Vector3 destination);
        void Insert(Vector3 position, Player player);
    }
}
