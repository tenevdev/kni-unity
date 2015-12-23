using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Sripts.Core.Board
{
	public class CellCoordinates
	{
		private int x, y;
		public CellCoordinates (int x,int y)
		{
			this.x = x;
			this.y = y;
		}

		public int getX()
		{
			return this.x;
		}

		public int getY()
		{
			return this.y;
		}
	}
}

