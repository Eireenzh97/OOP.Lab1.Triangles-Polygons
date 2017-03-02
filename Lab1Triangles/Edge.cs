using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Edge
    {
        Point p1; 
        Point p2; 

        public Point P1 { get { return p1; } }
        public Point P2 { get { return p2; } }

        public Edge(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2));
            }
        }

    }
}
