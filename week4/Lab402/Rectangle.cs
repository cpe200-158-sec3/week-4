using System;

namespace Lab4
{
	public class Rectangle:Shape
	{
        private double _width;
        private double _height;

        public double Width 
        {
            get { return _width; }
            set 
            {
                if (value > 0)
                { _width = value; }
                else
                { _width = 1.0; }
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                { _height = value; }
                else
                { _height = 1.0; }
            }
        }

		public Rectangle ():base("gold")
		{
            _width = 1.0;
            _height = 1.0;
		}
        public Rectangle(string c, double w, double h):base(c)
        {
            _width = w;
            _height = h;
        }
        public Rectangle(Rectangle r):base(r.color)
        {
            _width = r._width;
            _height = r._height;
        }
        public override double getArea()
        {
            return _width * _height;
        }
        public override double getPerimeter()
        {
            return 2 * (_width + _height);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", _width, _height, getArea(), color);
        }
	}
}

