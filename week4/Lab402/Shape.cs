using System;

namespace Lab4
{
    public abstract class Shape
    {

        private readonly string _Color = "gold";
        public string color
        {
            get { return _Color; }
        }
        public Shape(string s)
        {
            _Color = s;
        }
        public abstract double getArea();
        public abstract double getPerimete();
        public override string ToString()
        {
            return _Color;
        }

    }
}

