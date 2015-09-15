using System;

namespace Lab4
{
	public class Rectangle:Shape
	{
        private double _width;
        private double _height;

        public double WWidth
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1;
                }
            }
        }
        public double HHeight
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1;
                }
            }
        }
        public Rectangle() : base("gold")
        {
            _height = 1;
            _width = 1;
        }
        public Rectangle(string c, double w, double h) : base(c)
        {
            _width = w;
            _height = h;
        }
        public Rectangle(Rectangle r) : base(r.Color)
        {
            _width = r._width;
            _height = r._height;
        }
        public override double getArea()
        {
            return _height * _width;
        }
        public override double getPerimeter()
        {
            return 2 * (_height + _width);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", _width, _height, getArea(), Color);
        }
    }
}

