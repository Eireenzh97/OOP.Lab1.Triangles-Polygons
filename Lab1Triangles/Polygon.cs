using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Polygon
    {
        public Point[] PointMas;
        private int size;
        private double[] length;

        public Polygon(Point[] pointArray)
        {
            PointMas = PointArray;
            size = PointMas.Length;

            Edge[] EdgeMas = new Edge[size]; //сколько точек создали, столько и рёбер
            for (int i = 0; i < size - 1; i++)
            {
                EdgeMas[i] = new Edge(PointMas[i], PointMas[i + 1]);
            }
            EdgeMas[size - 1] = new Edge(PointMas[size - 1], PointMas[0]); //последнее ребро соединяет первую и последнюю точку 

            this.length = new double[size];
            for (int i = 0; i < size; i++)
            {
                length[i] = EdgeMas[i].Length;
                if (length[i] == 0 || size < 3)
                {
                    Console.WriteLine("Ваш многоугольник не существует");
                }
            }
        }

        public double Perimeter//=======================================================================================
        {
            get
            {
                double perimeter = 0;
                for (int i = 0; i < size; i++)
                    perimeter = perimeter + length[i];
                return perimeter;
            }
        }

        public double Area//===========================================================================================
        {
            get
            {
                double area = 0;
                for (int i = 0; i < size - 1; i++)
                {
                    area += (PointMas[i].X * PointMas[i + 1].Y - PointMas[i].Y * PointMas[i + 1].X);
                }
                area += (PointMas[size - 1].X * PointMas[0].Y - PointMas[size - 1].Y * PointMas[0].X);
                return Math.Abs(area / 2);
            }
        }
    }


}
}
        

    

