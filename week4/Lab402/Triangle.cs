using System;
namespace Lab4
{
    public class Triangle : Shape
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
        public Triangle() : base("gold")
        {
            prWidth = 1;
            prHeight = 1;
        }
        public Triangle(string color, double width, double height) : base(color)
        {
            prWidth = width;
            prHeight = height;
        }
        public Triangle(Triangle t) : base(t.Color)
        {
            prWidth = t.prWidth;
            prHeight = t.prHeight;
        }
        public override double getArea()
        {
            return 0.5 * prWidth * prHeight;
        }
        public override double getPerimeter()
        {
            return prHeight + Math.Sqrt(Math.Pow(prHeight, 2) + Math.Pow(prWidth, 2)) + prWidth;
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color={3}]", prWidth, prHeight, getArea(), Color);
        }
    }
}