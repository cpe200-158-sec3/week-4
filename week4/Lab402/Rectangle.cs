using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab4
{
	public class Rectangle : Shape
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
        public Rectangle() : base("gold")
        {
            this.Width = 1;
            this.Height = 1;
        }
        public Rectangle(string color, double width, double height) : base(color)
        {
            this.Width = width;
            this.Height = height;
        }
        public Rectangle(Rectangle R) : base(R.Color)
        {
            this.Width = R.Width;
            this.Height = R.Height;
        }
        public override double getArea()
        {
            return this.Width * this.Height;
        }

        public override double getPerimeter()
        {
            return (Width + Height) * 2; 
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), base.ToString());
        }
    }
}

