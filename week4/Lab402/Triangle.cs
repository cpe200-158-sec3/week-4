using System;

namespace Lab4
{
	public class Triangle:Shape
	{
        

        public Triangle():base("gold") {
            _Width = 1;
            _Height = 1;
        }

        public Triangle(string c, double w, double h) : base(c) {
            _Width = w;
            _Height = h;
        }

        public Triangle(Rectangle R) : base(R.color) {
            _Width = R.Width;
            _Height = R.Height;
        }

        public override double getArea()
        {
            return 0.5 * _Width * _Height;
        }

        public override double getPerimeter() {
            return Math.Sqrt((Math.Pow(_Height, 2) + Math.Pow(_Width, 2))) + _Width + _Height;
        }

        public override string ToString() //[Triangle: base=4, height=5, area=10, color="blue"]
        {
            return "[Triangle: base=" + _Width + ", height=" + _Height + ", area=" + getArea() + ", color=\"" + base.color + "\"]";
        }
    }
}

