using System;
namespace Lab4
{
    public abstract class Shape
    {
        private readonly string prColor = "gold";
        public string Color
        {
            get
            {
                return prColor;
            }
        }
        public Shape(string color)
        {
            prColor = color;
        }
        public override string ToString()
        {
            return "";
        }
        public abstract double getArea();
        public abstract double getPerimeter();
    }
}