using System;
using System.Text.RegularExpressions;

namespace Lab402
{
    public class Rectangle : Shape
    {
        private double width = 1;
        private double heigh = 1;

        public double Width
        {
            set
            {
                if (value > -1)
                { width = value; }
            else
                { width = 1; } }
            get
                { return width; }
        }

        public double Height
        {
            set { if (value > -1)
                { heigh = value; } }
            get
                { return heigh; } }

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
        public Rectangle(Rectangle R) : base(R.color)
        {
            Width = R.Width;
            Height = R.Height;

        }
        public override double getArea()
        {
            return Width * Height;
        }
        public override double getPerimeter()
        {
            return 2 * (width + heigh);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: Width={0}, Height={1}, area={2}, color = \"{3}\" ]", Width, Height, getArea(), color);
        }
    }
}

