using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Sripts.Core.Board
{
    /// <summary>
    /// It might be a good idea to use the built-in Vector2 from Unity.
    /// I am not exactly sure about the purpose of this class.
    /// </summary>
	public class CellCoordinates
	{
        /// <summary>
        /// Initialise a cell position on given coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
		public CellCoordinates (int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

        public int X { get; set; }
        public int Y { get; set; }

        public void setToCoordinates(CellCoordinates coords)
		{
            X = coords.X;
            Y = coords.Y;
		}

	}
}

