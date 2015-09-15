using System;

namespace Lab402
{
	public class Rectangle : Shape
	{
		public Rectangle(): base("gold")
		{
            _height = 1;
            _width = 1;
		}

        public Rectangle (string c, double w, double h) : base(c)
        {
            _width = w;
            _height = h;
        }

        public Rectangle (Rectangle r) : base(r.color)
        {
            _height = r._height;
            _width = r._width;
        }

        public override double getArea()
        {
            return _width * _height;
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), base.color);
        }

        public override double getPerimeter()
        {
            return 2 * (_width + _height);
        }
    }
}

