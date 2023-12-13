namespace Pathfinder_A_Star
{
    internal struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            int hashCode = 1861411795;
            int seed = -1521134295;

            hashCode = hashCode * seed + X.GetHashCode();
            hashCode = hashCode * seed + Y.GetHashCode();

            return hashCode;
        }

        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !left.Equals(right);
        }
    }
}
