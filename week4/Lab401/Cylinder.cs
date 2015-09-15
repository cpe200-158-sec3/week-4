using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Cylinder : Circle
    {
        private double _height;
        public double Height
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
                    Console.WriteLine("Error height default=1.0");
                }
            }
        }

        public Cylinder() : base(0, 0, 1)
        {
            _height = 1.0;
        }

        public Cylinder(double rad, double h) : base(0, 0, rad)
        {
            _height = h;
        }

        public Cylinder(double x, double y, double rad, double h) : base(x, y, rad)
        {
            _height = h;
        }

        public Cylinder(Circle c) : base(c.X, c.Y, c.Radius)
        {
            _height = 1;
        }

        public Cylinder(Cylinder cy) : base(cy.X, cy.Y, cy.Radius)
        {
            _height = cy.Height;
        }

        public override double getArea()
        { //2pirh+2pir^2
            return 2 * Math.PI * radius * _height + 2 * Math.PI * Math.Pow(radius, 2);
        }

        public double getVolume()
        {
            return base.getArea() * _height;
        }

        public override string ToString() //[Cylinder: center(0,0), radius=1, height=1, surface=12.5663706143592, volume=3.14159265358979]
        {
            return "[Cylinder: center(" + base.X + "," + base.Y + "), radius=" + base.Radius + ", height=" + Height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
        }
    }
}