using System;
using System.Runtime.Remoting.Messaging;

namespace Lab4
{
	public class Triangle:Shape
	{
		private double width;
		private double height;
		public double Width { set{ if (value > -1) {width = value;} } get{ return width; } }
		public double Height { set{ if (value > -1) {height = value;} } get{ return height; }}



		public Triangle () : base("gold")
		{
			Width = 1;
			Height = 1;


		}
		public Triangle (string c,double w,double h):base(c)
		{
			Width = w;
			Height = h;


		}
		public Triangle (Rectangle r):base(r.color)
		{
			Width = r.Width;
			Height = r.Height;



		}
		public override double getArea ()
		{
			return 0.5 * Width * Height;
		}
		public override double getPerimeter ()
		{
			return Math.Sqrt ((Math.Pow (Height,2)) + (Math.Pow (Width,2)) ) + Width + Height;
		}
		public override string ToString ()
		{
			return string.Format ("[Triangle: base={0}, height={1}, area={2}, color = \"{3}\"]", Width, Height,getArea (),color);
		}
	}
}

