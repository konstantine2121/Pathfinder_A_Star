using System.Collections.Generic;

namespace Pathfinder_A_Star
{
    internal interface INextNodeChoosingStrategy
    {
        PathNode ChooseNode(IEnumerable<PathNode> reachable, Point targetPoint);
    }
}
