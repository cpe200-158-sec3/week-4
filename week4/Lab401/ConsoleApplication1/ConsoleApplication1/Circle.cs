using System;

namespace Lab4
{
	public class Circle:Point
	{

        private double radius = 1;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }



		public Circle ()
		{
            radius = 1;

		}
        public Circle (double r)
        {
           this.radius = r;
        }
        public Circle(double x,double y,double r)
            :base (x,y)
        {
            this.radius = r;
        }
        public Circle(Circle c)
            : base(c.X, c.Y)
        {
            radius = c.Radius;
        }
        public void setCircle(double x,double y,double r)
        {
            this.X = x;
            this.Y = y;
            radius = r;
        } 
        public virtual double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return "Circle: center(" + base.X + "," + base.Y + ")" + ", radius = " + radius + ", area = " + getArea();
        }
    }
}

