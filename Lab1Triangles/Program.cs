using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 6);
            Point p3 = new Point(5, 0);

            Triangle triangle = new Triangle(p1, p2, p3);
            Console.WriteLine("Периметр треугольника = {0}", triangle.Perimeter);
            Console.WriteLine("Площадь треугольника = {0}", triangle.Area);

            if (triangle.IsRight)
                Console.WriteLine("Треугольник - прямоугольный");
            if (triangle.IsIsosceles)
                Console.WriteLine("Треугольник - равнобедренный");

            Console.WriteLine("Введите количество треугольников в массиве: ");
            int count = Convert.ToInt32(Console.ReadLine());
            ArrayOfTriangles(count);

            //=================================================================
            Console.WriteLine("Введите количество углов в многоугольнике: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Point[] arrPoint = ArrayOfPoints(size);
            Polygon poligon = new Polygon(arrPoint);
            PrintPolygon(arrPoint);

            Console.WriteLine(poligon.Perimeter);
            Console.WriteLine(poligon.Area);

            Console.Read();

        }

        static void ArrayOfTriangles(int count) //=================================================================================
        {
            Triangle[] arrTriangle = new Triangle[count];
            double TrPerimeter = 0, TrArea = 0;
            int countRight = 0, countIsosceles = 0;
            for (int i = 0; i < count; i++)
            {
                Point p1 = new Point(0, 5);
                Point p2 = new Point(5, 5);
                Point p3 = new Point(0, 0);

                arrTriangle[i] = new Triangle(p1, p2, p3);

                if (arrTriangle[i].IsRight)
                {
                    TrPerimeter = TrPerimeter + arrTriangle[i].Perimeter;
                    countRight++;
                }
                if (arrTriangle[i].IsIsosceles)
                {
                    TrArea = TrArea + arrTriangle[i].Area;
                    countIsosceles++;
                }
            }

            if (countRight != 0)
                Console.WriteLine("Средний периметр прямоугольных треугольников = {0}", TrPerimeter/countRight);
            else
                Console.WriteLine("Средний периметр прямоугольных треугольников = 0");

            if (countIsosceles != 0)
                Console.WriteLine("Средняя площадь равнобедренных треугольников {0}", TrArea/countIsosceles);
            else
                Console.WriteLine("Средняя площадь равнобедренных треугольников = 0");

            
        }

        static Point[] ArrayOfPoints(int size)//===================================================
        {
            Point[] arrPoint = new Point[size];

            for (int i = 0; i < size; i++)
            {
                int j = i + 1;
                Console.WriteLine("Введите координаты " + j + "-ой точки: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                arrPoint[i] = new Point(x, y);
            }
            return arrPoint;
        }

        static void PrintPolygon(Point[] arrPoint)//=============================================================
        {
            int size = arrPoint.Length;
            for (int i = 0; i < size; i++)
            {
                int j = i + 1;
                Console.WriteLine(j + "-я точка: (" + arrPoint[i].X + ", " + arrPoint[i].Y + ")");
            }
        }
    }
}
