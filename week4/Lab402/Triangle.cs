using System;

namespace Lab4
{
    public class Triangle : Shape
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
                    _Width = 1;
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
        public Triangle()
            : base("gold")
        {
            _Width = 1;
            _Height = 1;
        }
        public Triangle(string c, double w, double h)
            : base(c)
        {
            _Width = w;
            _Height = h;
        }
        public override double getArea()
        {
            return .5 * _Width * _Height;
        }
        public override double getPerimeter()
        {
            return _Width + Math.Sqrt(Math.Pow(_Width / 2, 2) + Math.Pow(_Height, 2)) * 2;
        }
        public override string ToString()
        {
            return string.Format("Triangle: base={0}, height={1}, area={2}, color={3}]", _Width, _Height, getArea(), color);
        }
    }
}

