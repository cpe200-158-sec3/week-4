using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    public class Circle : Point
    {
        private double _radius;

        public double radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (_radius < 1)
                {
                    _radius = 1;
                }
                else
                {
                    _radius = value;
                }
            }
        }
        public Circle()
        {
            _radius = 1;
        }
        public Circle(double r)
        {
            _radius = r;
        }
        public Circle(double x, double y, double r) : base(x, y)
        {

            _radius = r;

        }
        public Circle(Circle c) : base(c.X, c.Y)
        {

            _radius = c.radius;
        }
        public void setCircle(double x, double y, double r)
        {
            _radius = r;
            new Point(x, y);
        }
        public double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return "[Circle: center(" + X + "," + Y + "), radius=" + _radius + ", area=" + getArea() + "]";
        }
    }
}
