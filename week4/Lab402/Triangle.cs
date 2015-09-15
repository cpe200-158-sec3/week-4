using System;

namespace Lab4
{
    public class Triangle : Shape
    {
        
       
        private double width;
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {

                    height = value;
                }
                else
                {
                    height = 1;
                }
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {

                    width = value;
                }
                else
                {
                    width = 1;
                }
            }
        }
        public Triangle() : base("gold")
        {
            Width = 1.0;
            Height = 1.0;
        }

        public Triangle(string _color, double _width, double _height) : base(_color)
        {
            Height = _height;
            Width = _width;
        }

        public Triangle(Rectangle a) : base(a.color)
        {
            Width = a.Width;
            Height = a.Height;
        }

        public override double getArea()
        {
            return 0.5 * Width * Height;
        }
        public override double getPerimete()
        {
            return Math.Sqrt((Math.Pow(Height, 2) + Math.Pow(Width, 2))) + Width + Height;
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"" ,Width,Height,getArea(),color);
        } 
    }
}

