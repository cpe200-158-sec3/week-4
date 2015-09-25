using System;

namespace Lab4
{
	public class Triangle : Shape
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

        public Triangle()
        {
            Height = 1.0;
            Width = 1.0;
            color = "gold";
        }

        public Triangle(string c, double w, double h)
        {
            Height = h;
            Width = w;
            color = c;
        }

        public Triangle(Triangle a)
        {
            Height = a.Height;
            Width = a.Width;
            color = a.Color;
        }

        public override double getArea()
        {
            return this.Height * this.Width / 2;
        }

        public override double getPerimeter()
        {
            return Math.Sqrt((this.Height) * (this.Height) + (this.Width) * (this.Width)) + this.Width + this.Height;
        }

        public override string ToString()
        {
            return string.Format("[Triangle: width={0}, height={1}, area={2}, color={3}{4}{5}]", this.Width, this.Height, this.getArea(), '"', this.Color, '"');
        }

    }
}

