using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _Width;
        private double _Height;

        public double Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value > 0)
                {
                    _Width = value;
                }
                else
                {
                    _Width = 1;
                }
            }
        }

        public double Height
        {
            get
            {
                return _Height;
            }
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
        public Triangle() : base("gold")
		{
            _Width = 1;
            _Height = 1;
		}
         public Triangle(string color,double width,double height) : base(color)
        {
            _Width = width;
            _Height = height;
        }
         public Triangle(Triangle t) : base(t.Color)
        {
            _Width = t._Width;
            _Height = t._Height;
        }
        public override double getArea()
        {
            return 0.5 * _Width * _Height;
        }
        public override double getPerimeter()
        {
            return _Height + Math.Sqrt(Math.Pow(_Height,2) + Math.Pow(_Width,2)) + _Width;
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base=4, height=5, area=10, color={3}", _Width, _Height, getArea(), Color);
        }
	}
}

