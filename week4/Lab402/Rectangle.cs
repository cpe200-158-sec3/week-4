using System;
namespace Lab4
{
    public class Rectangle : Shape
    {
        private double prWidth;
        private double prHeight;
        public double Width
        {
            get
            {
                return prWidth;
            }
            set
            {
                if (value > 0)
                {
                    prWidth = value;
                }
                else
                {
                    prWidth = 1;
                }
            }
        }
        public double Height
        {
            get
            {
                return prHeight;
            }
            set
            {
                if (value > 0)
                {
                    prHeight = value;
                }
                else
                {
                    prHeight = 1;
                }
            }
        }
        public Rectangle()
            : base("gold")
        {
            prWidth = 1;
            prHeight = 1;
        }
        public Rectangle(string color, double width, double height)
            : base(color)
        {
            prWidth = width;
            prHeight = height;
        }
        public Rectangle(Rectangle r)
            : base(r.Color)
        {
            prWidth = r.prWidth;
            prHeight = r.prHeight;
        }
        public override double getArea()
        {
            return prWidth * prHeight;
        }
        public override double getPerimeter()
        {
            return 2 * (prHeight + prWidth);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", prWidth, prHeight, getArea(), Color);
        }
    }
}