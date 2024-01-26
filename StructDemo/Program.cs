// Chris Cascioli
// 1/26/24
// Example of structs and their usage

namespace StructDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Make some points
			Point p1 = new Point(5, 6);
			Point p2 = p1;

			//p1.X += 999;

			ChangePoint(p1);
			//ChangePoint(p2);

			Console.WriteLine($"Point 1 is ({p1.X},{p1.Y})");
			Console.WriteLine($"Point 2 is ({p2.X},{p2.Y})");

			// Create a list of points
			List<Point> points = new List<Point>();
			points.Add(new Point(20, 30));
			points.Add(new Point(-4, -9));

			// This won't work because Point is a struct:
			//points[0].X += 10;

			// This is fine but causes two copies
			//points[0] = new Point(points[0].X + 10, points[0].Y);

			// Copy / Alter / Replace
			Point copy = points[0];
			copy.X += 10;
			points[0] = copy;

		}

		/// <summary>
		/// Adds 50 to the point's X and Y values
		/// </summary>
		/// <param name="p">Point to change</param>
		public static void ChangePoint(Point p)
		{
			p.X += 50;
			p.Y += 50;
		}
	}
}