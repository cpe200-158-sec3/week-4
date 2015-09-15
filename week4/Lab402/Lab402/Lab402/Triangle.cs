using System;

namespace Lab402
{
	public class Triangle:Shape
	{
        private double width;
        private double height;

        public double Width {
            get { return width; }
            set {
                    if (value > 0)
                    {
                        width = value;
                    }
                    else
                    {
                        width = 1.0;
                    }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    height = 1.0;
                }
            }
        }

        public Triangle() : base("gold")
        {
            width = 1.0;
            height = 1.0;
        }

        public Triangle(string color, double width, double height) : base(color)
        {
           this.width = width;
           this.height = height;
        }

        public Triangle(Triangle triangle) : base(triangle.Color)
        {
            width = triangle.width;
            height = triangle.height;
        }

        public override double getArea()
        {
            return 0.5 * height * width;
        }

        public override double getPerimeter()
        {
            return (height + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2)) + width);
        }

        //[Triangle: base=4, height=5, area=10, color="blue"]
        public override string ToString()
        {
            //return string.Format("[Triangle: base=4, height=5, area=10, color={3}",width, height, getArea(), Color);

             return "[Triangle: base="+width+ ", height="+height+ ", area="+getArea()+ ", color="+Color+"]";
        }

    }
}

