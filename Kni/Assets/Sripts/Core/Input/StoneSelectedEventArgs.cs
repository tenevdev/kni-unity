using Assets.Sripts.Core.Stone;
using System;

namespace Assets.Sripts.Core.Input
{
    public class StoneSelectedEventArgs : EventArgs
    {
        public StoneSelectedEventArgs(IMovable stone)
        {
            this.Stone = stone;
        }

        public IMovable Stone { get; set; }
    }
}