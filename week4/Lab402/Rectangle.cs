using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _Width, _Height;
        public double Width
        {
            get { return _Width; }
            set
            {
                if (value > 0)
                {
                    _Width = value;
                }
                else
                {
                    _Width = 1.0;
                }
            }
        }
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value > 0)
                {
                    _Height = value;
                }
                else
                {
                    _Height = 1;
                }
            }
        }
		public Rectangle():base("gold")
		{
            _Height = 1;
            _Width = 1;
        }
        public Rectangle(string c,double w,double h):base(c)
        {
            _Height = h;
            _Width = w;
        }
        public Rectangle(Rectangle r) : base(r.color)
        {
            _Height = r._Height;
            _Width = r._Width;
        }
        public override double getArea()
        {
            return _Height * _Width;
        }
        public override double getPerimeter()
        {
            return 2 * (_Height + _Width);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", _Width, _Height, getArea(), color);
        }
    }
}

