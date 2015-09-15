using System;
using System.Dynamic;

namespace Lab4
{
	public abstract class Shape
	{
		private readonly string Color = "gold";
		public string color{ get{ return Color; }}
		public Shape(string c)
		{
			Color = c;
		}

		public abstract double getArea ();
		public override string ToString ()
		{
			return string.Format ("color= {0}",Color);
		}
		public abstract double getPerimeter ();
	}
}

