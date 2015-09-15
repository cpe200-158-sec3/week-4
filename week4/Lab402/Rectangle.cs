using System;

namespace Lab4
{
    
	public class Rectangle:Shape
	{
        private double _width;
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
        public Rectangle() : base("gold")
        {
            Width = 1;
            Height = 1;
        }
        public Rectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(Rectangle r) : base(r.Color)
        {
            Width = r.Width;
            Height = r.Height;
        }
        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimeter()
        {
            return 2 * (Height + Width);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", Width, Height, getArea(), Color);
        }
    }
}

	

