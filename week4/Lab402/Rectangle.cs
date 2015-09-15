using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab402
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get {
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
                    Console.WriteLine("Error: Width > 0");
                    width = 1;
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
                    height = 1;
                }
            }
        }

        public Rectangle() : base("gold")
        {
            height = 1.0;
            width = 1.0;
            color = "gold";
        }
        public Rectangle(String c, double w, double h) : base(c)
        {
            height = h;
            width = w;
        }
        public Rectangle(Rectangle r1) : base(r1.Color)
        {
            width = r1.Width;
            height = r1.Height;
        }

        public override double getArea()
        {
            return width * height;
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", width, height, getArea(), base.color);
        }
        public override double getPerimeter()
        {
            return 2 * (width + height);
        }

    }
}