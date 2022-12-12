using System;

namespace Ex
{
    class Point
    {
        public  int X;
        public  int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Flip()
        {
            int value = X;
            X = (-1) * Y;
            Y = (-1) * value;
        }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2));
        }

         public string ToString()
        {
            return $"({X}, {Y})";
        }

        public static void Main()
        {
            Point point1 = new Point(5, -7);
            Point point2 = new Point(6, -8);
            double distance = point1.Distance(point2);
            Console.WriteLine(distance);
            point1.Flip();
            string str = point1.ToString();
            Console.WriteLine(str);
        }
    }
}