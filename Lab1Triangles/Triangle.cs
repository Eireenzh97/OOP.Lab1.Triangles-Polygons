using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Triangle
    {
        public Point P1;
        public Point P2;
        public Point P3;

        double e1_len, e2_len, e3_len;

        public Triangle(Point point1, Point point2, Point point3) //================================================================
        {
            this.P1 = point1;
            this.P2 = point2;
            this.P3 = point3;

            Edge e1 = new Edge(P1, P2);
            Edge e2 = new Edge(P1, P3);
            Edge e3 = new Edge(P2, P3);

            e1_len = e1.Length; 
            e2_len = e2.Length;
            e3_len = e3.Length;

            if (e1_len >= e2_len + e3_len || 
                e2_len >= e1_len + e3_len || 
                e3_len >= e1_len + e2_len || 
                e1_len == 0 || e2_len == 0 || e3_len == 0)
            {
                Console.WriteLine("Треугольник не существует");
            }
        }

        public double Perimeter//====================================================================================================
        {
            get
            {
                return e1_len + e2_len + e3_len;
            }
        }

        public double Area//======================================================================================
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - e1_len) * (p - e2_len) * (p - e3_len));
            }
        }

        public bool IsRight//==================================================================================
        {
            get
            {
                return e1_len == Math.Sqrt(Math.Pow(e2_len, 2) + Math.Pow(e3_len, 2)) ||
                       e2_len == Math.Sqrt(Math.Pow(e1_len, 2) + Math.Pow(e3_len, 2)) ||
                       e3_len == Math.Sqrt(Math.Pow(e1_len, 2) + Math.Pow(e2_len, 2));
            }
        }

        public bool IsIsosceles//=============================================================================
        {
            get
            {
                return e1_len == e2_len || e2_len == e3_len || e1_len == e3_len;
            }
        }

    }
}
