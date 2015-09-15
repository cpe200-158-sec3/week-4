using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Circle
    {
        Point center = new Point();
        private double radius = 1;
        private double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
            }
        }
        public Double getRadius()
        {
            return radius;
        }
        public Circle()
        {
            this.Radius = 1;
            this.center.x = 0;
            this.center.y = 0;
        }
        public Circle(double radius)
        {
            this.Radius = radius;
            this.center.x = 0;
            this.center.y = 0;
        }
        public Circle(double x, double y, double radius)
        {
            this.Radius = radius;
            this.center.x = x;
            this.center.y = y;
        }
        public Circle(Circle C)
        {
            this.Radius = C.Radius;
            this.center.x = C.center.x;
            this.center.y = C.center.y;
        }
        public void setCircle(double x, double y, double radius)
        {
            this.Radius = radius;
            this.center.x = x;
            this.center.y = y;
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
            s = "[Circle: " + center + ", radius=" + radius + ", area=" + getArea() + "]";
            return s;
        }
    }
}

