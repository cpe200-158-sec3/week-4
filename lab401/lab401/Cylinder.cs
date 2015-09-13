using System;

namespace Lab401
{
    class Cylinder : Circle
    {
        private double height = 1;

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public Cylinder()
        {
            height = 1;
        }

        public Cylinder(double radius, double height)
            : base(radius)
        {
            this.height = height;
        }

        public Cylinder(double x, double y, double radius, double height)
            : base(x, y, radius)
        {
            this.height = height;
        }

        public Cylinder(Circle a)
            : base(a.X, a.Y, a.Radius)
        {
            this.height = 1;
        }

        public Cylinder(Cylinder b)
            : base(b.X, b.Y, b.Radius)
        {
            height = b.Height;
        }

        public override double getArea()
        {
            return (2 * Math.PI * base.Radius * height) + (2 * Math.PI * Math.Pow(base.Radius, 2));
        }

        public double getVolume()
        {
            return Math.PI * Math.Pow(base.Radius, 2) * height;
        }

        public override string ToString()
        {
            return "Cylinder: center(" + base.X + "," + base.Y + ")" + ", radius = " + base.Radius + ", height = " + height + ", surface = " + getArea() + ", volume = " + getVolume();
        }
    }
}