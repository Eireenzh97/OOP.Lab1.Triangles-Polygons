using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Triangle
    {
        Point p1, p2, p3;
        Edge e1, e2, e3; 

        public Point P1 { get { return p1; } }
        public Point P2 { get { return p2; } }
        public Point P3 { get { return p3; } }

        public Edge E1 { get { return e1; } }
        public Edge E2 { get { return e2; } }
        public Edge E3 { get { return e3; } }
        public Triangle(Point point1, Point point2, Point point3)
        {
            this.p1 = point1;
            this.p2 = point2;
            this.p3 = point3;

            e1 = new Edge(P1, P2);
            e2 = new Edge(P1, P3);
            e3 = new Edge(P2, P3);
        }

        public Triangle()
        {
            Random gen = new Random();
           
            do
            {
                Point p1 = new Point(gen.Next(0, 10), gen.Next(0, 10));
                Point p2 = new Point(gen.Next(0, 10), gen.Next(0, 10));
                Point p3 = new Point(gen.Next(0, 10), gen.Next(0, 10));

                e1 = new Edge(p1, p2);
                e2 = new Edge(p2, p3);
                e3 = new Edge(p3, p1);

            } while (Exist());

            
        }
        private bool Exist()
        {
            if (!(e1.Length < e2.Length + e3.Length &&
                   e2.Length < e1.Length + e3.Length &&
                   e3.Length < e1.Length + e2.Length &&
                   e1.Length != 0 && e2.Length != 0 && e3.Length != 0 ))
            {
                
                Console.WriteLine("В треугольнике неккоректные координаты");
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Perimeter
        {
            get { return e1.Length + e2.Length + e3.Length; }
        }

        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - e1.Length) * (p - e2.Length) * (p - e3.Length));
            }
        }

        public bool IsRight
        {
            get
            {
                return e1.Length == Math.Sqrt(Math.Pow(e2.Length, 2) + Math.Pow(e3.Length, 2)) ||
                       e2.Length == Math.Sqrt(Math.Pow(e1.Length, 2) + Math.Pow(e3.Length, 2)) ||
                       e3.Length == Math.Sqrt(Math.Pow(e1.Length, 2) + Math.Pow(e2.Length, 2));
            }
        }

        public bool IsIsosceles
        {
            get
            {
                return e1.Length == e2.Length || e2.Length == e3.Length || e1.Length == e3.Length;
            }
        }

    }
}
