using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Cylinder:Circle
    {
        private double _Height;
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value >= 0)
                {
                    _Height = value;
                }
                else
                {
                    _Height = 1;
                }
            }
        }
        public Cylinder()
        {
            x = 0;
            y = 0;
            radius = 1;
            Height = 1;
        }
        public Cylinder(double r, double h)
        {
            x = 0;
            y = 0;
            radius = r;
            Height = h;
        }
        public Cylinder(double x, double y, double r, double h)
        {
            this.x = x;
            this.y = y;
            radius = r;
            Height = h;
        }
        public Cylinder(Circle c)
        {
            x = c.x;
            y = c.y;
            radius = c.radius;
            Height = 1;
        }
        public Cylinder(Cylinder cl)
        {
            x = cl.x;
            y = cl.y;
            radius = cl.radius;
            Height = cl.Height;
        }

        public override double getArea()
        {
            return 2 * Math.PI * Math.Pow(radius, 2) + 2 * Math.PI * radius * Height;
        }
        public double getVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * Height; 
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", x, y, radius,Height, getArea(), getVolume());
        }
    }
}
