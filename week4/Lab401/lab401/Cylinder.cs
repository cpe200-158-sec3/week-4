using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Cylinder : Circle
    {
        public double height;

        public Cylinder() : base(0,0,1)
        {
            height = 1.0;
        }

        public Cylinder(double radius,double height) : base(0,0,radius)
        {
            this.height = height;
        }

        public Cylinder(double x, double y, double radius,double height) : base(x, y, radius)
        {
            this.height = height;
        }

        public Cylinder(Circle a) : base(a.x,a.y,a.Radius)
        {
            height = 1.0;
        }

        public Cylinder(Cylinder a) : base(a.x,a.y,a.Radius)
        {
            this.height = a.height;
        }
        

        public override double getArea()
        {
            return (2 * Math.PI * Radius * height) + (2 * Math.PI * Radius * Radius);
        }

        public double getVolume()
        {
            return Math.PI * Radius * Radius * height;
        }

        public override string ToString()
        {
            string display = "[Cylinder: center(" + x + "," + y + "), radius=" + Radius + ", height=" + height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
            return display;
        }
    }
}
