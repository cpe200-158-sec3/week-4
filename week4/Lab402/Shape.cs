using System;

namespace Lab4
{
	public abstract class Shape
	{
        private readonly string _color = "gold";
        public string Color
        {
            get
            {
                return _color;
            }
        }
        public Shape(string color)
        {
            _color = color;
        }

        public override string ToString()
        {
            return "";
        }

        public abstract double getArea();
        public abstract double getPerimeter();
        
    }
}
    
