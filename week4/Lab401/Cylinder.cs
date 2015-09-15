using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        private double _height = 1;
        private double Height
        {
            get { return _height; }
            set
            {
                if (value >= 0)
                {
                    _height = value;
                }
            }
        }
        public Cylinder()
        {
            this.Height = 1;
        }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.Height = height;
        }
        public Cylinder(double x, double y, double radius, double height) : base(x, y, radius)
        {
            this.Height = height;
        }
        public Cylinder(Circle c) : base(c)
        {
            this.Height = 1;
        }
        public Cylinder(Cylinder Cy) : base(Cy.x, Cy.y, Cy.getRadius())
        {
            this.Height = Cy.Height;
        }
        public double getArea()
        {
            double area;
            area = (2 * Math.PI * getRadius() * Height) + (2 * Math.PI * Math.Pow(getRadius(), 2));
            return area;
        }
        public double getVolume()
        {
            double volume;
            volume = (Math.PI * Math.Pow(getRadius(), 2)) * Height;
            return volume;
        }
        public override string ToString()
        {
            string s;
            s = "[Cylinder: center(" + x + "," + y + "), radius=" + getRadius() + ", height=" + Height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
            return s;
        }
    }
}

