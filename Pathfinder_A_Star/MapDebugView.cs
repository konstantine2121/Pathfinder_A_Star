using System.Text;

namespace Pathfinder_A_Star
{
    internal class MapDebugView
    {
        private const char Border = '█';

        private readonly Map _map;

        public MapDebugView(Map map)
        {
            _map = map;
        }

        public string View
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();

                var borderWidth = _map.Width + 2;
                var topDownBorder = new string(Border, borderWidth);
                
                stringBuilder.AppendLine(topDownBorder);

                for (int y = 0; y < _map.Height; y++)
                {
                    AddRowText(stringBuilder, y);
                }

                stringBuilder.AppendLine(topDownBorder);

                return stringBuilder.ToString();
            }
        }

        private void AddRowText(StringBuilder stringBuilder, int y)
        {
            stringBuilder.Append(Border);

            for (int x = 0; x < _map.Width; x++)
            {
                stringBuilder.Append(_map[x, y] ? Map.Wall : Map.Floor);
            }

            stringBuilder.Append(Border);
            stringBuilder.AppendLine();
        }
    }
}
