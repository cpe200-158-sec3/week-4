using System;

namespace Lab4
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value >= 0)
                {
                    width = value;
                }
                else
                {
                    width = 1;
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                else
                {
                    height = 1;
                }
            }
        }
        public Rectangle() : base("gold")
        {
            Width = 1;
            Height = 1;
        }
        public Rectangle(string c, double w, double h) : base(c)
        {
            Width = w;
            Height = h;
        }
        public Rectangle(Rectangle r) : base(r.color)
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
            return 2 * (width + height);
        }
        public override string ToString()
        {
            return "[Regtangle: width=" + width + ", height=" + height + ", area=" + getArea() + ", color=" + base.ToString() + "]";
        }
    }
}

