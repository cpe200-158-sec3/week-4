using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Cylinder : Circle
    {
        private Double height;
        private int v;
        Point center = new Point();
        private double radius = 1;
        private double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
            }
        }

        public Cylinder()
        {
            height = 1;
        }
        public Cylinder(Circle C) : base(C)
        {
            height = 1;
        }

        public Cylinder(Double radius, Double height)
            : base(radius)
        {
            this.height = height;
        }


        public Cylinder(double radius, double A, double B, int v) : base(radius, A, B)
        {
            this.v = v;
        }

        public Double getHeight()
        {
            return height;
        }


        public Double setHeight(Double height)
        {
            this.height = height;
            return height;
        }

        public Double getArea()
        {
            return ((Math.PI * Math.Pow(getRadius(), 2)) * 2 + (2 * Math.PI * getRadius() * height));
        }

        public Double getVolume()
        {
            return ((Math.PI * Math.Pow(getRadius(), 2) * height));
        }

        public override string ToString()
        {
            string s;
            s = "[Circle: " + center + ", radius=" + radius + ", height=" + getHeight() + ", surface= " + getArea() + ", volume= " + getVolume() + "]";
            return s;
        }

    }
}

