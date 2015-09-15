using System;

namespace Lab4
{
	public abstract class Shape
	{
        private readonly string Color ="gold";

        public string color {
            get {
                return Color;
            }
        }

        protected double _Width;
        protected double _Height;

        public double Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value > 0)
                {
                    _Width = value;
                }
                else
                {
                    _Width = 1;
                }
            }
        }
        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (value > 0)
                {
                    _Height = value;
                }
                else
                {
                    _Height = 1;
                }
            }
        }

        public Shape(string c) {
            Color = c;
        }

        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
            return Color;
        }
	}
}

