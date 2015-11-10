using System;

namespace Lab401
{
	public class Cylinder : Circle
	{
		protected double Height;

		public double height
		{
			get
			{
				return Height;	
			}
			set 
			{
				if (value >= 0) 
				{
					Height = value;
				} else 
				{
					Console.WriteLine ("ERROR!");
				}
			}
		}

		public Cylinder ():base(0,0,1)
		{
			Height = 1.0;
		}
		public Cylinder (double r, double h):base(0,0,r)
		{
			Height = h;
		}
		public Cylinder (double x, double y, double r, double h):base(x,y,r)
		{
			Height = h;
		}
		public Cylinder (Circle c):base(c)
		{
			Height = 1.0;
		}
		public Cylinder (Cylinder y)
		{
			Height = y.Height;
			base.X = y.X;
			base.Y = y.Y;
			base.Radius = y.Radius;
		}
		public override double getArea()
		{
			return (2 * Math.PI * base.Radius * Height) + 2 * base.getArea();
		}
		public double getVolume()
		{
			return base.getArea () * Height;
		}
		public override string ToString ()
		{
			return string.Format ("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", base.X, base.Y, base.Radius, Height, getArea() ,getVolume());
		}
	}
}

//circle
//testcommit

//commit