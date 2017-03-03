using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Triangle
    {
        public Point P1, P2, P3;
        public Edge e1, e2, e3; 
        public Triangle(Point point1, Point point2, Point point3)
        {
            this.P1 = point1;
            this.P2 = point2;
            this.P3 = point3;

            e1 = new Edge(P1, P2);
            e2 = new Edge(P1, P3);
            e3 = new Edge(P2, P3);
        }

        public Triangle()
        {
            Random gen = new Random();
           
            do
            {
                Point P1 = new Point(gen.Next(0, 10), gen.Next(0, 10));
                Point P2 = new Point(gen.Next(0, 10), gen.Next(0, 10));
                Point P3 = new Point(gen.Next(0, 10), gen.Next(0, 10));

                e1 = new Edge(P1, P2);
                e2 = new Edge(P2, P3);
                e3 = new Edge(P3, P1);

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
