using System;
using System.Drawing;

namespace ActividadFADA
{
    class Program
    {
        private static readonly Random randon = new(Guid.NewGuid().GetHashCode());

        private static Point p1 = new(Console.WindowWidth / 2, 1);
        private static Point p2 = new(5, Console.WindowHeight - 1 );
        private static Point p3 = new(Console.WindowWidth -5, Console.WindowHeight - 1);

        private const int iterations = 100000;

        static void Main(string[] args)
        {
            DrawTriangle();
            Console.Read();
        }

        static private Point GetRandomPoint() 
        {
            int n = randon.Next(1, (3+1));

            switch (n)
            {
                case 1:

                    return p1;
                    break;

                case 2:

                    return p2;
                    break;


                default:

                    return p3;
                    break;
            }
        }

        static private Point GetMiddlePoint(Point p1, Point p2) 
        {
            return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }

        static void DrawPoint(Point point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("*");
        
        }

        static void DrawTriangle()
        {
            Point currentP = GetRandomPoint();
            DrawPoint(currentP);

            for (int i = 0; i < iterations; i++)
            {
                Point middlePoint = GetMiddlePoint(currentP, GetRandomPoint());

                DrawPoint(middlePoint);
                currentP = middlePoint;

            }

        }

    }
}
