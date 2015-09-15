using System;

namespace Lab4
{
	public abstract class Shape
	{
        private readonly string _color = "gold";
        public string Color{
            get {
                return _color;
            }
        }
		public Shape (string c)
		{
            _color = c;
		}
        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
         return string.Format(_color);
        }
	}
}

