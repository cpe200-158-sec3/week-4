using System;

namespace Lab4
{
    public class Rectangle : Shape
    {
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

