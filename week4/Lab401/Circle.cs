using System;

namespace Lab4
{
	public class Circle
	{
		private Point _center;
        private double _radius+ 1.0;
	}

    public Point Center { get; set; }
    public double Radius { get; set; }

    public Circle()
    {
        _center = new Point();
    }

    public Circle(double rad)
    {
        _center = new Point();
        _radius = rad;
    }

    public Circle(double x,double y,double rad)
    {
        _center = new POint();
        _radius = rad;
    }

    public Circle (Circle cir)
    {
        _center = new Point(cir.Center);
        _radius = cir.Radius;
    }
    
    public void setCircle(double x,double y,double rad)
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
        return "[Cylinder: center(" + Center.X + ", " + Center.Y + "), radius=" + Radius + ", height=" + _height + ", surface=" + getSurface() + ", volume=" + getVolume() + "]";
    }
}

