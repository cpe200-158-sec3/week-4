using System;

namespace Lab4
{
    public class Point
    {
        public double x, y;
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            string s;
            s = "center(" + x + "," + y + ")";
            return s;
        }
    }
}

