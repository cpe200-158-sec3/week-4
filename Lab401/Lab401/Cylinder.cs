using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Cylinder :Circle
    {
        private double _height;

        public double height
        {
            get
            {
                return _height;
            }
            set
            {
                if (_height < 1)
                {
                    _height = 1;
                }
                else
                {
                    _height = value;
                }
            }
        }
        public Cylinder()
        {
            _height = 1;
        }
        public Cylinder(double r, double h) : base(r)
        {
            _height = h;
        }
        public Cylinder(double x, double y, double r, double h) : base(x,y,r)
        {
            _height = h;
        }
        public Cylinder(Circle c) : base(c.X,c.Y,c.radius)
        {
            _height = 1;
        }
        public Cylinder(Cylinder cl) : base(cl.X, cl.Y, cl.radius)
        {
            _height = cl.height;
        }
        public double getArea()
        {
            return 2 * Math.PI* (radius* _height + Math.Pow(radius, 2));
        }
        public double getVolume()
        {
            return Math.PI* Math.Pow(radius, 2) * _height;
        }
        public override string ToString()
        {
            return "[Cylinder: center(" + X + "," + Y + "), radius=" + radius + ", height=" + _height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
        }
    }
}
