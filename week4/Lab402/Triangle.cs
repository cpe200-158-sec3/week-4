using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Triangle : Shape
    {
        private double _width = 1;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = 1;
            }
        }
        private double _height = 1;
        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = 1;
            }
        }
        public Triangle() : base("gold")
        {
            this.Width = 1;
            this.Height = 1;
        }
        public Triangle(string color, double width, double height) : base(color)
        {
            this.Width = width;
            this.Height = height;
        }
        public Triangle(Rectangle R) : base(R.Color)
        {
            this.Width = R.Width;
            this.Height = R.Height;
        }
        public override double getArea()
        {
            return (1 / 2) * Width * Height;
        }
        public override double getPerimeter()
        {
            return Height + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2)) + Width;
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), base.ToString());
        }
    }
}

