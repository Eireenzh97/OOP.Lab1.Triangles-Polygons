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
            //===Проверка работоспособности свойств класса Triangle
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

            //==========Создание массива треугольников

            Triangle[] triangle1 = ArrayOfTriangles(10000);

            double TrPerimeter = 0, TrArea = 0;
            int CountRight = 0, CountIsosceles = 0;

            for (int i = 0; i < triangle1.Length; i++)
            {
                if (triangle1[i].IsRight)
                {
                    TrPerimeter = TrPerimeter + triangle1[i].Perimeter;
                    CountRight++;
                }
                if (triangle1[i].IsIsosceles)
                {
                    TrArea = TrArea + triangle1[i].Area;
                    CountIsosceles++;
                }
            }

            if (CountRight != 0)
                Console.WriteLine("Средний периметр прямоугольных треугольников = {0}", TrPerimeter / CountRight);
            else
                Console.WriteLine("Средний периметр прямоугольных треугольников = 0");

            if (CountIsosceles != 0)
                Console.WriteLine("Средняя площадь равнобедренных треугольников {0}", TrArea / CountIsosceles);
            else
                Console.WriteLine("Средняя площадь равнобедренных треугольников = 0");




            //=================================================================
            Console.WriteLine("Введите количество углов в многоугольнике: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Point[] ArrPoint = ArrayOfPoints(size);
            Polygon polygon = new Polygon(ArrPoint);
            PrintPolygon(ArrPoint);

            Console.WriteLine("Периметр многоугольника = {0}", polygon.Perimeter);
            Console.WriteLine("Площадь многоугольника = {0}", polygon.Area);

            Console.Read();

        }

        static Triangle[] ArrayOfTriangles(int count) //=================================================================================
        {
            Triangle[] ArrTriangle = new Triangle[count];
            for (int i = 0; i < count; i++)
            {
                ArrTriangle[i] = new Triangle();

            }  
                return ArrTriangle;           
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
