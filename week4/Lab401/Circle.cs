using System;

namespace Lab401
{
    class Circle : Point
    {
        protected Point center;
        protected double radius;

        public Point Center
        {
            get
            {
                return center;
            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (radius >= 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("invalid radius");
                }
            }
        }
        public Circle() : base(0, 0)
        {
            radius = 1;
        }
        public Circle(double r) : base(0, 0)
        {
            radius = r;
        }
        public Circle(double x, double y, double r) : base(x, y)
        {
            radius = r;
        }
        public Circle(Circle c) : base(c.x, c.y)
        {
            radius = c.radius;
        }
        public void setCircle(double x, double y, double r)
        {
            base.X = x;
            base.Y = y;
            radius = r;
        }
        public double getArea()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return "[Circle: center(" + base.X + "," + base.Y + "), " + "Radius=" + radius + ", Area=" + getArea() + "]";
        }
    }
}

