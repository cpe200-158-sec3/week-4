using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Circle : Point
    {
        protected double radius;
        protected Point center;


        public double Radius
        {
            get { return radius; }
            set
            {
                if (value >= 0) { radius = value; }
                else { Console.WriteLine("Error Radius must be at least 0"); }
            }
        }

        public Point Center
        {
            get { return center; }
        }

        public Circle()
            : base(0, 0)
        {
            radius = 1.0;

        }

        public Circle(double rad)
            : base(0, 0)
        {
            radius = rad;

        }

        public Circle(double x, double y, double rad)
            : base(x, y)
        {
            radius = rad;

        }

        public Circle(Circle c)
            : base(c.X, c.Y)
        {
            radius = c.Radius;

        }

        public void setCircle(double x, double y, double rad)
        {
            base.X = x;
            base.Y = y;
            radius = rad;

        }
        public virtual double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }


        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}]", base.X, base.Y, Radius, getArea());
        }
    }
}