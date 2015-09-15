using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab401
{
    class Cylinder : Circle
    {
        protected double height;

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (height >= 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("invalid height");
                }
            }
        }
        public Cylinder()
            : base(0, 0, 1)
        {
            height = 1;
        }
        public Cylinder(double r, double h)
            : base(0, 0, r)
        {
            height = h;
        }
        public Cylinder(double x, double y, double r, double h)
            : base(x, y, r)
        {
            height = h;
        }
        public Cylinder(Circle a)
            : base(a.X, a.Y, a.Radius)
        {
            height = 1;
        }
        public Cylinder(Cylinder a)
            : base(a.X, a.Y, a.radius)
        {
            height = a.height;
        }
        public override double getArea()
        {
            return (2 * Math.PI * base.Radius * height) + (2 * Math.PI * Math.Pow(base.Radius, 2));
        }
        public double getVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        public override string ToString()
        {
            return "[Cylinder: center (" + base.X + "," + base.Y + "), Radius=" + radius + ", Height=" + height + ", Surface=" + getArea() + ", Volume=" + getVolume() + "]";
        }
    }
}
