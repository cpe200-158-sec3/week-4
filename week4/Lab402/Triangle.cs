using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _width;
        public double Width {
            get { return _width;}
            set {
                if (value > 0)
                {
                    _width = value;
                }
                else {
                    _width = 1;
                }
            }
        }
        private double _height;
        public double Height
        {
            get { return _height; }
            set {
                if (value > 0)
                {
                    _height = value;
                }
                else {
                    _height = 1;
                }
            }
        }
		public Triangle ():base("gold"){
                _width = 1;
                _height = 1;
    }
        public Triangle(string color, double _width, double _height):base(color)
		{
            this._width = _width;
            this._height = _height;
		}
        public Triangle(Rectangle R) :base(R.Color){
            _width = R.Width;
            _height = R.Height;
        }
        public override double getArea()
        {
            return 0.5 * _width * _height;
        }
        public override double getPerimeter()
        {
            return _height + Math.Sqrt(Math.Pow(_height, 2) + Math.Pow(_width, 2)) + _width;
        }
        public override string ToString() {
            return string.Format("[Triangle: base={0} height={1}, area={2}, color={3}", _width, _height, getArea(), Color);
        } 
	}
}

