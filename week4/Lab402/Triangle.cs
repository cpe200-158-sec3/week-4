using System;

namespace Lab4
{
	public class Triangle:Shape
	{
        private double _width;
        private double _height;

        public double Width
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

        public double Height
        {
            get
            {
                return _height;
            }
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
            Width = 1;
            Height = 1;
        }
        public Triangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public Triangle(Triangle t) : base(t.Color)
        {
            Width = t.Width;
            Height = t.Height;
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


