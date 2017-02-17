using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Edge
    {
        public Point P1; //1-я точка ребра
        public Point P2; //2-я точка ребра

        public Edge(Point p1, Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public double Length//длина ребра
        {
            get
            {
                return Math.Sqrt(Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2));
            }
        }

    }
}
