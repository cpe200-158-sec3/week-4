using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab402
{
    public class Triangle : Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Error: Width > 0");
                    width = value;
                }
            }
        }

        public double Height
        {
            get {
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
                    Console.WriteLine("Error: Height > 0");
                    height = value;
                }
            }
        }

        public Triangle() : base("gold")
        {
            height = 1.0;
            width = 1.0;

        }
        public Triangle(String c, double w, double h) : base(c)
        {
            height = h;
            width = w;
        }

        public Triangle(Triangle t1) : base(t1.Color)
        {
            width = t1.Width;
            height = t1.Height;
        }

        public override double getArea()
        {
            return 0.5 * width * height;
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", width, height, getArea(), base.color);
        }
        public override double getPerimeter()
        {
            return Math.Sqrt((Math.Pow(height, 2) + Math.Pow(width, 2))) + width + height;
        }
    }
}