using System;

namespace Lab4
{
    public class Circle : Point
    {
        private double _radius;
        public double radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    _radius = 1;
                }

            }

        }
        public Circle()
        {
            x = 0;
            y = 0;
            radius = 1;
        }
        public Circle(double r)
        {
            x = 0;
            y = 0;
            radius = r;
        }
        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            radius = r;
        }
        public Circle(Circle a)
        {
            x = a.x;
            y = a.y;
            radius = a.radius;

        }
        public void setCircle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            radius = r;
        }

        public virtual double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}]", x, y, radius, getArea());
        }

    }
}