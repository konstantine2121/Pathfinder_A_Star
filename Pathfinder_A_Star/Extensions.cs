namespace Pathfinder_A_Star
{
    internal static class Extensions
    {
        public static bool BelongsToMap(this Node node, Map map)
        {
            return Range.Contains(map.Width, node.X) && 
                Range.Contains(map.Height, node.Y);
        }

        public static bool Contains(this Map map, Node node) 
        {
            return node.BelongsToMap(map);
        }
    }

}
