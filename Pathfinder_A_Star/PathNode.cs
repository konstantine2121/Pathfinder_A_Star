namespace Pathfinder_A_Star
{
    internal class PathNode
    {
        public PathNode(Point point, PathNode previous = null)
        {
            Location = point;
            Previous = previous;
        }

        public PathNode(int x, int y, PathNode previous = null) : 
            this(new Point(x, y), previous)
        {
        }

        public Point Location { get; }

        public PathNode Previous { get; }

        public bool HasPrevious => Previous != null;

        public override bool Equals(object obj)
        {
            return obj is PathNode node &&
                   Location == node.Location;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator == (PathNode left, PathNode right)
        {
            if (ReferenceEquals(left, right)) return true;

            if (left is null || right is null) return false;

            return left.Location == right.Location;
        }

        public static bool operator !=(PathNode left, PathNode right)
        {
            return !(left == right);
        }

        public static implicit operator Point(PathNode node) 
        {
            return node.Location;
        }
    }

}
