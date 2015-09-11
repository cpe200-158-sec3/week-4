using System;

namespace Lab401
{
    public class Cylinder : Circle
	{
        private double _height;
        public double height
        {
            get { return _height; }
            set
            {
                if (value >= 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
            }
        }
        public Cylinder()
		{
            _height = 1.0;
		}
        public Cylinder(double r, double h) : base(r)
        {
            _height = h;
        }
        public Cylinder(double x, double y, double r, double h) : base(x, y, r)
        {
            _height = h;
        }
        public Cylinder(Circle c) : base(c.x, c.y, c.radius)
        {
            _height = 1.0;
        }
        public Cylinder(Cylinder cl) : base(cl.x, cl.y, cl.radius)
        {
            _height = cl._height;
        }
        public double getArea()
        {
            return 2 * Math.PI * (radius * _height + Math.Pow(radius, 2));
        }
        public double getVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * _height;
        }
        public override string ToString()
        {
            return "[Cylinder: center(" + x + "," + y + "), radius=" + radius + ", height=" + _height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
        }
    }
}

