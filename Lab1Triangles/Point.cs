using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Point
    {
        int x;
        int y;
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
    }
}
