using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Polygon
    {
        public Point[] pointMas;
        private int size;
        private double[] length;

        public Polygon(Point[] pointArray)
        {
            pointMas = pointArray;
            size = pointMas.Length;

            Edge[] edgeMas = new Edge[size]; //сколько точек создали, столько и рёбер
            for (int i = 0; i < size - 1; i++)
            {
                edgeMas[i] = new Edge(pointMas[i], pointMas[i + 1]);
            }
            edgeMas[size - 1] = new Edge(pointMas[size - 1], pointMas[0]); //последнее ребро соединяет первую и последнюю точку 

            this.length = new double[size]; 
            for (int i = 0; i < size; i++)
            {
                length[i] = edgeMas[i].Length;
                if (length[i] == 0 || size < 3)
                {
                    Console.WriteLine("Ваш многоугольник не существует");
                }
            }

            
        }

    }

        

    }
}
