using System;

namespace Lab4
{
    public class Circle
    {
        private Point _center;
        private double _radius = 1.0;


        public Point Center
        {
            set { _center = value; }
            get { return _center; }
        }
        public double Radius
        {
            set { _radius = value; }
            get { return _radius; }
        }
        public Circle ()
        {
            _center = new Point();
        }

        public Circle(double rad)
        {
            _center = new Point();
            _radius = rad;
        }

        public Circle(double x, double y, double rad)
        {
            _center = new Point(x,y);
            _radius = rad;
        }

        public Circle(Circle cir)
        {
            _center = new Point(cir.Center);
            _radius = cir.Radius;
        }

        public void setCircle(double x, double y, double rad)
        {
            _center.X = x;
            _center.Y = y;
            _radius = rad;
        }

        public double getArea()
        {
            return Math.PI * _radius * _radius;
        }

        override public string ToString()
        {
            return "[Circle: center(" + Center.X + ", " + Center.Y + "), radius=" + _radius + ", area=" + getArea() + "]";
        }
    }
    }
