using System.Collections.Generic;
using System.Linq;

namespace Pathfinder_A_Star.NodeChoosing
{
    internal class ClosestToTargetNodeChooser : INextNodeChoosingStrategy
    {
        public PathNode ChooseNode(IEnumerable<PathNode> reachable, Point targetPoint)
        {
            var ordered = reachable
                .OrderBy(node => node.Location.GetDistance(targetPoint));

            return ordered.FirstOrDefault();
        }
    }
}
