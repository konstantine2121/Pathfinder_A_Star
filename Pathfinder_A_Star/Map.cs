using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Pathfinder_A_Star
{
   [DebuggerTypeProxy(typeof(MapDebugView))]
    internal class Map
    {
        #region Constants

        public const char Wall = '#';
        public const char Floor = ' ';

        #endregion Constants

        #region Fields

        private bool[,] _cells = new bool[0, 0];

        #endregion Fields

        #region Properties

        public bool this[int left, int top]
        {
            get { return _cells[top, left]; }
        }

        public bool this[Node node]
        {
            get { return this[node.X, node.Y]; }
        }

        public int Height => _cells.GetLength(0);

        public int Width => _cells.GetLength(1);

        #endregion Properties

        #region Methods

        public void Load(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);
                var width = lines.Max(line => line.Length);
                var height = lines.Length;

                _cells = new bool[height, width];

                for (int i = 0; i < height; i++)
                {
                    var line = lines[i];

                    for (int j = 0; j < width && j < line.Length; j++)
                    {
                        if (line[j] == Wall)
                        {
                            _cells[i, j] = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion Methods
    }
}
