using System;

namespace Lab4
{
	public class Rectangle:Shape
	{

        public Rectangle():base("gold") {
            _Width = 1;
            _Height = 1;
        }

        public Rectangle(string c, double w, double h):base(c) {
            _Width = w;
            _Height = h;
        }

        public Rectangle(Rectangle R):base(R.color) {
            _Width = R.Width;
            _Height = R.Height;
        }

        public override double getArea() {
            return _Width * _Height;
        }
        public override double getPerimeter()
        {
            return (_Width + _Height) * 2;
        }

        public override string ToString() //[Rectangle: width=4, height=5, area=20, color="red"]
        {
            return "[Rectangle: width=" + _Width + ", height=" + _Height + ", area=" + getArea() + ", color=\"" + base.color + "\"]";
        }
	}
}

