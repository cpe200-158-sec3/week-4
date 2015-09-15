using System;

namespace Lab4
{
    public class Circle:Point
    {
        private double radius = 1;
        private double Radius
        {
            get { return radius; }
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
            }
        }
        public Circle() : base(0, 0)
        {
            this.Radius = 1;
        }
        public Circle(double radius) : base(0, 0)
        {
            this.Radius = radius;
        }
        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.Radius = radius;
        }
        public Circle(Circle C)
        {
            this.Radius = C.Radius;
            x = C.x;
            y = C.y;
        }
        public void setCircle(double x, double y, double radius)
        {
            this.Radius = radius;
            base.x = x;
            base.y = y;
        }
        public double getArea()
        {
            double area;
            area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
        public override string ToString()
        {
            string s;
            s = "[Circle: " + base.ToString() + ", radius=" + radius + ", area=" + getArea() + "]";
            return s;
        }

        //for Cyclinder Class
        public double getRadius()
        {
            return Radius;
        }
    }
}

