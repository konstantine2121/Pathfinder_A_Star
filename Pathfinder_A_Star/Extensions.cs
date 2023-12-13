namespace Pathfinder_A_Star
{
    internal static class Extensions
    {
        public static bool BelongsToMap(this Point point, Map map)
        {
            return Range.Contains(map.Width - 1, point.X) && 
                Range.Contains(map.Height - 1, point.Y);
        }

        public static bool Contains(this Map map, Point point) 
        {
            return point.BelongsToMap(map);
        }
    }

}
