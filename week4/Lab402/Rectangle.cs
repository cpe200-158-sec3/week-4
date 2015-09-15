using System;

namespace Lab4
{
    public class Rectangle : Shape
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
        public Rectangle()
            : base("gold")
        {
            _Width = 1;
            _Height = 1;
        }
        public Rectangle(string color, double width, double height)
            : base(color)
        {
            _Width = width;
            _Height = height;
        }
        public Rectangle(Rectangle r)
            : base(r.Color)
        {
            _Width = r._Width;
            _Height = r._Height;
        }
        public override double getArea()
        {
            return _Width * _Height;
        }

        public override double getPerimeter()
        {
            return 2 * (_Height + _Width);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", _Width, _Height, getArea(), Color);
        }
    }
}