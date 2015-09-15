using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab402
{
	public class Rectangle: Shape
	{
        private double _width ;
        private double _height ;

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
                   Console.WriteLine("Error: Width must be > 0");
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
                    Console.WriteLine("Error: Height must be > 0");
                    _height = 1;
                }
            }
        }

		public Rectangle () : base("gold")
		{
            _height = 1.0;
            _width = 1.0;
            _color = "gold";
		}
        public Rectangle (String c, double w,double h): base(c)
        {
            _height = h;
            _width = w;
        }
        public Rectangle(Rectangle r1): base(r1.Color)
        {
            _width = r1.Width;
            _height = r1.Height;
        }

        public override double getArea()
        {
            return _width * _height;
        }

        public override double getPerimeter()
        {
            return (_width * 2)+(_height*2);
        }
        public override string ToString()
        {
            return "[Rectangle: width=" + _width + ", height=" + _height + ", area=" + getArea() + ", color=" + _color + "]";
        }

	}
}

