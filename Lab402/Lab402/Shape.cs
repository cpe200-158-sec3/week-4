using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab402
{
    public abstract class Shape
    {
        private readonly string _Color = "gold";
        public string Color
        {
            get
            {
                return _Color;
            }
        }
        public Shape(string color)
        {
            _Color = color;
        }

        public abstract double getArea();
        public abstract double getPerimeter();

        public override string ToString()
        {
            return "";
        }
    }
}
