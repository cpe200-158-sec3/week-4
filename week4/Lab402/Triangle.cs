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
        public Triangle() : base("gold")
        {
            _width = 1;
            _height = 1;
        }
        public Triangle(string col, double wid, double hei) : base(col)
        {
            _width = wid;
            _height = hei;
        }
        public override double getArea()
        {
            return 0.5 * Width * Height;
        }
        public override double getPerimeter()
        {
            return Height + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2)) + Width;
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color={3}]", Width, Height, getArea(), Color);
        }
    }
}