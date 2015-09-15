﻿using System;

namespace Lab4
{
	public class Rectangle:Shape
	{
		private double width;
		private double height;
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
		public Rectangle ():base("gold")
		{
			height = 1.0;
			width = 1.0;
		}
		public Rectangle (string a, double w, double h):base(a)
		{
			width = w;
			height = h;
		}
		public Rectangle (Rectangle r):base(r.color)
		{
			width = r.Width;
			height = r.Height;
		}
		public override double getArea ()
		{
			return width * height;
		}
		public override string ToString ()
		{
			return string.Format ("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", width, height, getArea(),base.color);
		}
		public override double getPerimeter ()
		{
			return 2 * (width + height);
		}
	}
}

