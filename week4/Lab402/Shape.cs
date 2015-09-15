using System;

namespace Lab4
{
    public abstract class Shape
    {
        private readonly string _color = "gold";
        public string Color
        {
            get { return _color; }
            //set { _color = "gold"; }
        }
        
        public Shape(string color)
        {
            _color = color;
        }

       
        public abstract double getArea();
        public abstract double getPerimeter();

         public override string ToString()
        {
            return "";
        }
 
        }
        
    }


