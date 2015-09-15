using System;

namespace Lab4
{
	public abstract class Shape
	{
        public readonly string Color;
		public Shape (string color)
		{
            Color = color;
		}
        public override string ToString()
        {
            return Color;
        }
        public abstract double getArea();
        public abstract double getPerimeter();
    }
}

