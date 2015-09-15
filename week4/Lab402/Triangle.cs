using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _width, _height;
        public double Width
        {
            get { return _width; }
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
        public double Height
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
		public Triangle ()
            :base("gold")
		{
            _width = 1;
            _height = 1;
		}
        public Triangle(string c, double w, double h)
            :base(c)
        {
            _height = h;
            _width = w;
        }
        //public Triangle(Triangle t)
        //    : base(t.Color)
        //{
        //    _height = t._height;
       //     _width = t._width;
       // }
        public override double getArea()
        {
            return .5 * _width * _height;
        }
        public override double getPerimeter()
        {
            return _width + Math.Sqrt(Math.Pow(_width, 2) + Math.Pow(_height, 2)) + _height;
        }
        public override string ToString()
        {
            return string.Format("Triangle: base={0}, height={1}, area={2}, color={3}]", _width, _height, getArea(), Color);
        }
	}
}

