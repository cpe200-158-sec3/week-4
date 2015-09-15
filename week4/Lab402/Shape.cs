using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab402
{
    public abstract class Shape
    {
        //abstract member
        public abstract double getArea();
        public abstract double getPerimeter();

        //concrete member
        public String color;

        public String Color
        {
            get {
                return color;
            }
        }

        public Shape(String c)
        {
            color = c;
        }

        public override string ToString()
        {
            return "[Shape: color=" + color + "]";
        }
    }
}