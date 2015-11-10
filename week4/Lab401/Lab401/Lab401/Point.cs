using System;

namespace Lab401
{
	public class Point
	{
		protected double x;
		protected double y;

		public double X
		{
			get 
			{
				return x;
			}
			set 
			{
				x = value;
			}
		}
		public double Y
		{
			get 
			{
				return y;
			}
			set 
			{
				y = value;
			}
		}

		public Point ()
		{
			x = 0;
			y = 0;
		}
		public Point (Point a)
		{
			x = a.X;
			y = a.Y;
		}
		public Point (double a, double b)
		{
			x = a;
			y = b;
		}
		public override string ToString ()
		{
			return string.Format ("[Point: X={0}, Y={1}]", X, Y);
		}
	}
}

//circle
//testcommit

//commit