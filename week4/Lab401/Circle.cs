using System;

namespace Lab4
{
    class Circle:Point
    {
        private double radius;
        public Point center;
        
        public double Radius { set { radius = value; } get { return radius; } }

        public Circle()
        {
            Radius = 1;
            center = new Point();
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public Circle(double x,double y,double r)
        {
            Radius = r;
            /*center.X = x;
            center.Y = y;*/
            center = new Point(x,y);
        }
        public Circle(Circle c)
        {
            Radius = c.Radius;
            /*center.X = c.X;
            center.Y = c.Y;*/
            center = new Point(c.center.X, c.center.Y);
        }
        public virtual double getArea()
        {
            return Math.PI*Radius*Radius;
        }
        public void setCircle(double x, double y, double r)
        {
            center = new Point(x,y);
            Radius = r;
        }
        public override string ToString()
        {
            return string.Format("[Circle: {0}, radius={1}, area={2}]",center,Radius,getArea());
        }

    }
}
