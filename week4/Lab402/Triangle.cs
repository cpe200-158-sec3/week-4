using System;

namespace Lab402
{
    public class Triangle : Shape
    {

        public Triangle() : base("gold")
        {
            Width = 1;
            Height = 1;
        }
        public Triangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public Triangle(Triangle t) : base(t.Color)
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
            return Height + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2)) + Width;
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color={3}]", Width, Height, getArea(), Color);
        }
    }
}