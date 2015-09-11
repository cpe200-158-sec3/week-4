using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Circle : Point
    {
        public Point Center;
        public double Radius;

        public Circle()
        {
            Center = new Point();
            Radius = 1.0;
        }

        public Circle(double radius)
        {
            Radius = radius;
            Center = new Point();
        }

        public Circle(double x, double y, double radius) : base(x,y)
        {
            Radius = radius;
            //Center = new Point(x,y);

        }

        public Circle(Circle a) : base(a.x,a.y)
        {
            this.Radius = a.Radius;
            //Center = a.Center;

        }

        public void setCircle(double x, double y, double radius)
        {
            this.Radius = radius;
            Center.x = x;
            Center.y = y;

        }

        public virtual double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            string display = "[Circle: center(" + x + "," + y + "), radius=" + Radius + ", area=" + getArea() + "]";
            return display;
        }
    }
}
