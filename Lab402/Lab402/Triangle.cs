using System;

namespace Lab4
{
    public class Triangle : Shape
    {       
        public Triangle() : base("gold")
        {
            Width = 1;
            Height = 1;
        }
        public Triangle(string c, double w, double h) : base(c)
        {
            Width = w;
            Height = h;
        }
        public Triangle(Triangle t) : base(t.color)
        {
            Width = t.Width;
            Height = t.Height;
        }
        public override double getArea()
        {
            return 0.5 * Width * Height;
        }
        public override double getPerimeter()
        {
            return Math.Sqrt((Math.Pow(height, 2) + Math.Pow(width, 2))) + width + height;
        }
        public override string ToString()
        {
            return "[Regtangle: width=" + width + ", height=" + height + ", area=" + getArea() + ", color=" + base.ToString() + "]";
        }
    }
}

