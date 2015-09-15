using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        public Rectangle() : base("gold"){
            Width = 1;
            Height = 1;
        }
        public Rectangle(string color, double _width, double _height) : base(color){
            this.Width =_width;
            this.Height = _height;
        }
        public Rectangle(Rectangle R) : base(R.Color){
            Width = R.Width;
            Height = R.Height;
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
            return string.Format("[Rectangle: width={0} height={1} area={2} color={3}]", Width, Height, getArea(), Color);
        }	
	}
}

