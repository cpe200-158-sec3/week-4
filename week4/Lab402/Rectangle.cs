using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _width;
        public double Width {
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
        private double _height;
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
		public Rectangle() : base("gold"){
            _width = 1;
            _height = 1;
        }
        public Rectangle(string color, double _width, double _height) : base(color){
            this._width =_width;
            this._height = _height;
        }
        public Rectangle(Rectangle R) : base(R.Color){
            _width = R._width;
            _height = R._height;
        }
        public override double getArea()
        {
            return _width * _height;
        }
        public override double getPerimeter()
        {
            return 2 * (_height + _width);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0} height={1} area={2} color={3}]", _width, _height, getArea(), Color);
        }	
	}
}

