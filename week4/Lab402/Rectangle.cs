using System;

namespace Lab4
{
    public class Rectangle : Shape
    {

        private double width;
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {

                    height = value;
                }
                else
                {
                    height = 1;
                }
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {

                    width = value;
                }
                else
                {
                    width = 1;
                }
            }
        }
        public Rectangle() : base("gold")

        {
            Width = 1.0;
            Height = 1.0;

        }
        public Rectangle(string _color, double _width, double _height) : base(_color)
        {
            Height = _height;
            Width = _width;
        }

        public Rectangle(Rectangle a) : base(a.color)
        {
            Height = a.height;
            Width = a.width;
        }
        public override double getArea()
        {
            return Width * Height;
        }
        public override double getPerimete()
        {
            return 2 * Width + 2 * Height;
        }

        public override string ToString() //[Rectangle: width=4, height=5, area=20, color="red"]
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}]\"", Width, Height, getArea(), color);

        }
    }

}
