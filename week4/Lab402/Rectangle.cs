using System;

namespace Lab4
{
	public class Rectangle:Shape
	{
		
           

        public Rectangle():base("gold")
        {
            width = 1;
            height = 1;
        }

        public Rectangle(string c,double w, double h):base(c)
        {
            width = w;
            height = h;
        }
        public Rectangle(Rectangle r):base(r.Color)
        {
            width = r.Width;
            height = r.Height;
        }


        public override double getArea()
        {
            return width*height;
        }
        public override double getPerimeter()
        {
            return 2*width + 2*height;
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]",Width,Height,getArea(),base.Color);
        }

//        

		

 	}
}

