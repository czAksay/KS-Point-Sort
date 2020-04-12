using System;
using System.Collections.Generic;

namespace Task1
{
    //Не понятно в задании, можно ли добавлять поля в Point.
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    class Program
    {
        static void Sort(List<Point> points)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < points.Count; j++)
                {
                    if (GetDistanceToPointO(points[j]) < GetDistanceToPointO(points[min]))
                    {
                        min = j;
                    }
                }
                Point tmp = points[i];
                points[i] = points[min];
                points[min] = tmp;
            }
        }

        static void Print(List<Point> points)
        {
            foreach (Point p in points)
            {
                Console.WriteLine(String.Format("X={0}\tY={1}\tZ={2}", p.X, p.Y, p.Z));
            }
        }

        //Можно хранить расстояние от точек до точки O в типе Point
        //и не считать его каждый раз заново. 
        static double GetDistanceToPointO(Point p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y + p.Z * p.Z);
        }

        static void Main(string[] args)
        {
            List<Point> points = new List<Point>()
            {
                new Point() { X = 0.1, Y = 0.2, Z = 142.6 },
                new Point() { X = 0.6, Y = 634.1, Z = 12.9 },
                new Point() { X = 0.9, Y = 12.2, Z = 34.6 },
                new Point() { X = 12.1, Y = 0.1, Z = 12.5 },
                new Point() { X = 346.8, Y = 23.5, Z = 346.1 },
                new Point() { X = 123.6, Y = 1.1, Z = 23.5 },
                new Point() { X = 123.3, Y = 54.8, Z = 643.1 },
                new Point() { X = 452.2, Y = 532.1, Z = 0 },
                new Point() { X = 234.5, Y = 43, Z = 664 }
            };
            Sort(points);
            Print(points);
        }
    }
}