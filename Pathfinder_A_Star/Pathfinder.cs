using System;
using System.Collections.Generic;

namespace Pathfinder_A_Star
{
    internal class Pathfinder
    {
        private readonly Map _map;

        public Pathfinder(Map map)
        {
            _map = map ?? throw new ArgumentNullException(nameof(map));
        }

        public bool FindPath(Node start, Node end, out List<Node> path)
        {
            path = new List<Node>();
            var reachable = new List<Node>();
            var explored = new List<Node>();

            if (!_map.Contains(start) || !_map.Contains(end))
            {
                return false;
            }

            path.Add(start);
            reachable.Add(start);

            return false;
        }


    }
}
