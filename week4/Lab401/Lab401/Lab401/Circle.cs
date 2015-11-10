using System;

namespace Lab401
{
	public class Circle : Point
	{
		protected Point center;
		protected double radius;

		public Point Center 
		{
			get 
			{
				return center;
			}
			set 
			{
				center = value;
			}
		}
		public double Radius
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
				} else 
				{
					Console.WriteLine ("ERROR!");
				}
			}
		}
		public Circle ():base(0,0)
		{
			radius = 1;
		}
		public Circle (double r):base(0,0)
		{
			radius = r;
		}
		public Circle(double x, double y, double r):base(x,y)
		{
			radius = r;
		}
		public Circle(Circle c)
		{
			radius = c.Radius;
			base.X = c.X;
			base.Y = c.Y;
		}

		public void setCircle(double x, double y, double r)
		{
			radius = r;
			base.X = x;
			base.Y = y;
		}
		public virtual double getArea()
		{
			return Math.PI * Math.Pow (radius, 2);
		}
		public override string ToString ()
		{
			return string.Format ("[Circle: center({0},{1}), radius={2}, area={3}]", base.X, base.Y,radius,getArea());
		}
		

	}
}
//circle
//testcommit

//commit
