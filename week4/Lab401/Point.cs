using System;

namespace Lab401
{
    class Point
    {
        protected double x;
        protected double y;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(Point a)
        {
            x = a.x;
            y = a.y;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "center (" + this.x + ", " + this.y + ")";
        }
    }
}


