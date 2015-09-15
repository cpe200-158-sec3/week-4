using System;

namespace Lab401
{
    
  public class Cylinder : Circle
    {
        protected double _height;

        public double height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value >= 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1;
                }
            }
        }

        public Cylinder()
        {
            x = 0;
            y = 0;
            radius = 1;
            height = 1;
        }

        public Cylinder(double r, double h)
        {
            x = 0;
            y = 0;
            radius = r;
            height = h;
        }

        public Cylinder(double x, double y, double r, double h)
        {
            this.x = x;
            this.y = y;
            radius = r;
            height = h;

        }
        public Cylinder(Circle a)
        {
            x = a.x;
            y = a.y;
           radius = a.radius;
            height = 1;
        }
        public Cylinder(Cylinder b)
       {
            x = b.x;
            y = b.y;
            radius = b.radius;
           height = b.height;

        }
        public override double getArea()
        {
            return 2 * Math.PI * Math.Pow(radius, 2) + 2 * Math.PI * radius * height;
        }
        public double getVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", x, y, radius, height, getArea(), getVolume());
        }

    }
} 
