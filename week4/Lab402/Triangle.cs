using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab402
{
	public class Triangle:Shape
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
                    _width = value;
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
                    _height = value;
                }
            }
        }

		public Triangle () : base("gold")
		{
            _height = 1.0;
            _width = 1.0;
            
		}
        public Triangle (String c, double w,double h) : base(c)
        {
            _height = h;
            _width = w;            
        }

        public Triangle(Triangle t1): base(t1.Color)
        {
            _width = t1.Width;
            _height = t1.Height;          
        }

        public override double getArea()
        {
            return 0.5 * _width * _height;
        }

        public override double getPerimeter()
        {
            return _height + Math.Sqrt(Math.Pow(_height, 2) + Math.Pow(_width, 2)) + _width;
        }

        public override string ToString()
        {
            return "[Triangle: width=" + _width + ", height=" + _height + ", area=" + getArea() + ", color=" + _color + "]";
        }
	}
}

