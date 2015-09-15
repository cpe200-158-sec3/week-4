using System;

namespace Lab4
{
	public class Circle: Point
	{
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = (value >= 0) ? value : 1.0; }
        }

        public Circle()
            : base(0, 0)
        {
            Radius = 1.0;
        }
        public Circle(double a)
            : base(0, 0)
        {
            Radius = a;
        }
        public Circle(double a, double b, double c)
            : base(a, b)
        {

            Radius = c;

        }
        public Circle(Circle a)
        {
            X = a.X;
            Y = a.Y;
            Radius = a.Radius;
        }
        public void SetCircle(double a, double b, double c)
        {
            X = a;
            Y = b;
            Radius = c;
        }
        public virtual double getArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius = {2}, area={3}", this.X, this.Y, this.Radius, this.getArea());
        }
		}
	}


