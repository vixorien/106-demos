// Chris Cascioli
// 1/26/24
// Represents a point in space 

namespace StructDemo
{
	internal struct Point
	{
		// Fields
		private int x;
		private int y;

		// Properties
		public int X { get { return x; } set { x = value; } }
		public int Y { get { return y; } set { y = value; } }

		// Constructor
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

	}
}
