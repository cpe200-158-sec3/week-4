using System;

namespace Lab402
{
	public class Triangle : Shape
	{
		public Triangle () : base("gold")
		{
            _width = 1;
            _height = 1;
		}

        public Triangle(string c, double w, double h) : base(c)
        {
            _width = w;
            _height = h;
        }

        public override double getArea()
        {
            return .5 * _height * _width;
        }

        public override double getPerimeter()
        {
            return _width + Math.Sqrt(Math.Pow(_width, 2) + Math.Pow(_height, 2)) + _height;
        }

        public override string ToString()
        {
            return string.Format(("[Triangle: base={0}, height={1}, area={2}, color={3}]"), _width, _height, getArea(), color);
        }
    }
}

