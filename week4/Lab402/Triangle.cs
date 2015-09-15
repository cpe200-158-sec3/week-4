using System;

namespace Lab4
{
	public class Triangle:Shape
	{
		public Triangle ():base("gold")
		{
            width = 1;
            height = 1;


		}
        public Triangle(string c, double w, double h)
            : base(c)
        {
            width = w;
            height = h;
        }
        public Triangle(Rectangle r)
            : base(r.Color)
        {
            width = r.Width;
            height = r.Height;
        }

        public override double getArea()
        {
            return 0.5 * width * height;
        }
        public override double getPerimeter()
        {
            return width + height + (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]",Width,Height,getArea(),base.Color);
        }
	}
}





