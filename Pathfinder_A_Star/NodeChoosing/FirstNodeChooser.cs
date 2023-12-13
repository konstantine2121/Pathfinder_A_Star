using System.Collections.Generic;
using System.Linq;

namespace Pathfinder_A_Star.NodeChoosing
{
    internal class FirstNodeChooser : INextNodeChoosingStrategy
    {
        public PathNode ChooseNode(IEnumerable<PathNode> reachable, Point targetPoint)
        {
            return reachable.First();
        }
    }
}
