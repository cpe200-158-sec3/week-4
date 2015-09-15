using System;

namespace Lab4
{
        public class Rectangle : Shape
        {
            private double width;
            private double height;

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
            public Rectangle() : base("gold")
            {
                width = 1;
                height = 1;
            }
            public Rectangle(string color, double w, double h): base(color)
            {
                 width = w;
                height = h;
            }
            public Rectangle(Rectangle r) : base(r.Color)
            {
                width = r.width;
                height = r.height;
            }
            public override double getArea()
            {
                return width * height;
            }

            public override double getPerimeter()
            {
                return 2 * (Height + Width);
            }
            public override string ToString()
            {
                return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", width, height, getArea(), Color);
            }
        }
    }




