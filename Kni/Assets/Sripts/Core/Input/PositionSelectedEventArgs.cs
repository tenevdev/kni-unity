using System;
using UnityEngine;

namespace Assets.Sripts.Core.Input
{
    public class PositionSelectedEventArgs : EventArgs
    {
        public PositionSelectedEventArgs(Vector3 position)
        {
            this.Position = position;
        }

        public Vector3 Position { get; set; }
    }
}