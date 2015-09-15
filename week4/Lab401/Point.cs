using System;

namespace Lab4
{
    public class Point
    {
        private double x;
        private double y;
        public double X { set { x = value; } get { return x; } }
        public double Y { set { y = value; } get { return y; } }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(Point a)
        {
            X = a.X;
            Y = a.Y;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("center({0},{1})",X,Y);
        }
    }
}
