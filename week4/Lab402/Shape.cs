using System;

namespace Lab4
{
	public abstract class Shape
	{
		protected readonly string Color = "gold";
		public string color
		{
			get 
			{
				return Color;
			}
		}

		public Shape (string a)
		{
			Color = a;
		}
		public override string ToString ()
		{
			return Color;
		}
		public abstract double getArea();
		public abstract double getPerimeter();

	}
}

