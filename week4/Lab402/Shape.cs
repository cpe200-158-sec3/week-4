using System;

namespace Lab4
{

    public abstract class Shape
    {
        private readonly string _Color = "gold";
        public string color
        {
            get
            {
                return _Color;
            }
        }

        public Shape(string c)
        {
            _Color = c;
        }
        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
            return string.Format(_Color);
        }
    }

	}


