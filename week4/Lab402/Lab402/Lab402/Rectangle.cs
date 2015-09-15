using System;

namespace Lab402
{
	public class Rectangle:Shape
	{
        private double width;
        private double height;

        public double Width {
            get { return width; }
            set { if (value > 0)
                    {
                        width = value;
                    }
                    else {
                        width = 1.0;
                    }
                }
        }

        public double Height {
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

		public Rectangle ():base("gold")
		{
            height = 1.0;
            width = 1.0;
		}

        public Rectangle(string color, double width, double height):base(color) {
            //this.Color = color;
            this.width = width;
            this.height = height;
        }

        public Rectangle(Rectangle rectangle):base(rectangle.Color) {
            //this.Color = rectangle.Color;
            this.width = rectangle.width;
            this.height = rectangle.height;
        }

        public override double getArea() {
            return width * height;
        }


        public override double getPerimeter()
        {
            return (2 * (height + width));
        }

        //[Rectangle: width=4, height=5, area=20, color="red"]
        public override string ToString()
        {
            return "[Rectangle: width="+width+", height="+height+", area="+getArea()+", color="+Color+"]";
        }
    }
}

