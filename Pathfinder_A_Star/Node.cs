namespace Pathfinder_A_Star
{
    internal class Node
    {
        public Node(int x, int y, Node previous = null)
        {
            X = x;
            Y = y;
            Previous = previous;
        }

        public int X { get; }

        public int Y { get; }

        public Node Previous { get; }

        public bool HasPrevious => Previous != null;

        public override bool Equals(object obj)
        {
            return obj is Node node &&
                   X == node.X &&
                   Y == node.Y;
        }

        public override int GetHashCode()
        {
            int hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }

        public static bool operator == (Node left, Node right)
        {
            if (ReferenceEquals(left, right)) return true;

            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator !=(Node left, Node right)
        {
            return !(left == right);
        }
    }

}
