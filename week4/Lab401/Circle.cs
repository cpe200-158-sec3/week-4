using System;

namespace Lab401
{
	public class Circle : Point
	{
        private double _radius;
        public double radius
        {
            get { return _radius; }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    _radius = 1.0;
                }
            }
        }
		public  Circle()
		{
            _radius = 1.0;
		}
        public Circle(double r)
        {
            _radius = r;
        }
        public Circle(double x, double y, double r) : base(x, y)
        {
            _radius = r;
        }
        public Circle(Circle c) : base(c.x, c.y)
        {
            _radius = c.radius;
        }
        public void setCircle(double x, double y,double r)
        {
            _radius = r;
            new Point(x, y);
        }
        public double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return "[Circle: center(" + x + "," + y + "), radius=" + _radius + ", area=" + getArea() + "]";
        }
    }
}

