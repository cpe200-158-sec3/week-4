using System;

namespace Lab4
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = Math.Max(value, 1); }
        }

            public override string Color
        {
            get { return color; }
        }

        public Rectangle()
        {
            Height = 1.0;
            Width = 1.0;
            color = "gold" ;
        }

        public Rectangle(string c, double w, double h)
        {
            Height = h;
            Width = w;
            color = c;
        }

        public Rectangle(Rectangle a)
        {
            Height = a.Height;
            Width = a.Width;
            color = a.Color;
        }

        public override double getArea()
        {
            return this.Height * this.Width;
        }

        public override double getPerimeter()
        {
            return this.Height * 2 + this.Width * 2;
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}{4}{5}]", this.Width, this.Height, this.getArea(), '"', this.Color, '"');
        }
    }
}
