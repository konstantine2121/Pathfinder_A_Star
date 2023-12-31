﻿using System;
using Pathfinder_A_Star.NodeChoosing;

namespace Pathfinder_A_Star
{
    internal class Example
    {
        private string _path = "field_01.txt";
        
        public void Run()
        {
            var map = new Map();
            map.Load(_path);

            var view = new MapDebugView(map);

            Console.WriteLine(view.View + "\n");

            //var pathfinder = new Pathfinder(map, new FirstNodeChooser());
            var pathfinder = new Pathfinder(map, new ClosestToTargetNodeChooser());

            var startPoint = new Point(0, 0);
            var endPoint = new Point(4, 3);

            Console.Write("Точка старта ");
            PrintPoint(startPoint);

            Console.Write("Точка финиша ");
            PrintPoint(endPoint);
            Console.WriteLine();

            if (pathfinder.FindPath(startPoint, endPoint, out var path))
            {
                Console.WriteLine("Путь найден:");

                foreach (var p in path)
                {
                    PrintPoint(p);
                }
            }
            else
            {
                Console.WriteLine("Путь не найден");
            }
        }

        private void PrintPoint(Point point)
        {
            Console.WriteLine($"{point.X, 4} {point.Y, 4}");
        }
    }
}
