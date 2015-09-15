using System;

namespace Lab4
{
    class Point
    {
        private double x, y;

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

        public Point(Point z)
        {
            x = z.X;
            y = z.Y;
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
