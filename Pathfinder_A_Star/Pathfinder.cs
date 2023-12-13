using System;
using System.Collections.Generic;
using System.Linq;

namespace Pathfinder_A_Star
{
    internal class Pathfinder
    {
        private readonly Map _map;

        public Pathfinder(Map map)
        {
            _map = map ?? throw new ArgumentNullException(nameof(map));
        }

        public bool FindPath(Point start, Point end, out LinkedList<PathNode> path)
        {
            path = null;
            var reachable = new LinkedList<PathNode>();
            var explored = new LinkedList<PathNode>();

            if (!_map.Contains(start) || !_map.Contains(end))
            {
                return false;
            }

            reachable.AddLast(new PathNode(start));

            while (reachable.Any())
            {
                var node = ChooseNode(reachable);

                if (node == end)
                {
                    path = BuildPath(node);
                    return true;
                }

                reachable.Remove(node);
                explored.AddLast(node);

                var newReachable = GetAdjacentNodes(node)
                    .Where(adjacent => !explored.Contains(adjacent));

                foreach (var adjacent in newReachable)
                {
                    if (!reachable.Contains(adjacent))
                    {
                        reachable.AddLast(adjacent);
                    }
                }
            }

            return false;
        }

        private PathNode ChooseNode(IEnumerable<PathNode> reachable)
        {
            return reachable.First();
        }

        private IEnumerable<PathNode> GetAdjacentNodes(PathNode node)
        {
            var points = new LinkedList<Point>();

            var location = node.Location;

            var startX = location.X - 1;
            var endX = location.X + 1;
            var startY = location.Y - 1;
            var endY = location.Y + 1;

            for (int y = startY; y <= endY; y++)
            {
                for (int x = startX; x <= endX; x++)
                {
                    if (x != location.X && 
                        y != location.Y)
                    {
                        continue;
                    }

                    var point = new Point(x, y);

                    if (point != location  &&
                        point.BelongsToMap(_map) &&
                        _map[point] == false)
                    {
                        points.AddLast(point);
                    }
                }
            }

            return points.Select(point => new PathNode(point, node));
        }

        private LinkedList<PathNode> BuildPath(PathNode end) 
        {
            var path = new LinkedList<PathNode>();
            var node = end;

            while (node != null) 
            {
                path.AddFirst(node);
                node = node.Previous;
            }

            return path;
        }
    }
}
