using System;

namespace Lab4
{
	public abstract class Shape
	{
		protected double width;
		protected double height;
		public double Width
		{
			get 
			{
				return width;
			}
			set 
			{
				if (value > 0) 
				{
					width = value;
				} 
				else 
				{
					width = 1.0;
				}
			}
		}
		public double Height
		{
			get 
			{
				return height;
			}
			set 
			{
				if (value > 0) 
				{
					height = value;
				} 
				else 
				{
					height = 1.0;
				}
			}
		}

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

