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
            Point[] ArrPoint = ArrayOfPoints(size);
            Polygon polygon = new Polygon(ArrPoint);
            PrintPolygon(arrPoint);

            Console.WriteLine(polygon.Perimeter);
            Console.WriteLine(polygon.Area);

            Console.Read();

        }

        static void ArrayOfTriangles(int count) //=================================================================================
        {
            Triangle[] ArrTriangle = new Triangle[count];
            double TrPerimeter = 0, TrArea = 0;
            int CountRight = 0, CountIsosceles = 0;
            for (int i = 0; i < count; i++)
            {
                //Point p1 = new Point(0, 5);
               // Point p2 = new Point(5, 5);
                //Point p3 = new Point(0, 0);
                
                Random ira = new Random();
                
                Point p1 = new Point(ira.Next(0, 20), ira.Next(0, 20));
                Point p2 = new Point(ira.Next(0, 20), ira.Next(0, 20));
                Point p3 = new Point(ira.Next(0, 20), ira.Next(0, 20));

                ArrTriangle[i] = new Triangle(p1, p2, p3);

                if (ArrTriangle[i].IsRight)
                {
                    TrPerimeter = TrPerimeter + ArrTriangle[i].Perimeter;
                    CountRight++;
                }
                if (ArrTriangle[i].IsIsosceles)
                {
                    TrArea = TrArea + ArrTriangle[i].Area;
                    CountIsosceles++;
                }
            }

            if (CountRight != 0)
                Console.WriteLine("Средний периметр прямоугольных треугольников = {0}", TrPerimeter/CountRight);
            else
                Console.WriteLine("Средний периметр прямоугольных треугольников = 0");

            if (CountIsosceles != 0)
                Console.WriteLine("Средняя площадь равнобедренных треугольников {0}", TrArea/CountIsosceles);
            else
                Console.WriteLine("Средняя площадь равнобедренных треугольников = 0");

            
        }

        static Point[] ArrayOfPoints(int size)//===================================================
        {
            Point[] ArrPoint = new Point[size];

            for (int i = 0; i < size; i++)
            {
                int j = i + 1;
                Console.WriteLine("Введите координаты " + j + "-ой точки: ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                ArrPoint[i] = new Point(x, y);
            }
            return ArrPoint;
        }

        static void PrintPolygon(Point[] ArrPoint)//=============================================================
        {
            int size = ArrPoint.Length;
            for (int i = 0; i < size; i++)
            {
                int j = i + 1;
                Console.WriteLine(j + "-я точка: (" + ArrPoint[i].X + ", " + ArrPoint[i].Y + ")");
            }
        }
    }
}
