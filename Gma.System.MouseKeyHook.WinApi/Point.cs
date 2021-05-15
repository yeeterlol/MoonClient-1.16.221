namespace Gma.System.MouseKeyHook.WinApi
{
	internal struct Point
	{
		public int X;

		public int Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public static bool operator ==(Point a, Point b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		public static bool operator !=(Point a, Point b)
		{
			return !(a == b);
		}

		public bool Equals(Point other)
		{
			return other.X == X && other.Y == Y;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(Point))
			{
				return false;
			}
			return Equals((Point)obj);
		}

		public override int GetHashCode()
		{
			return (X * 397) ^ Y;
		}
	}
}
