﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            int distance = (int)Math.Sqrt((Math.Pow(X - x, 2) + Math.Pow(Y - y, 2)));
            return distance;
        }
    }
}
