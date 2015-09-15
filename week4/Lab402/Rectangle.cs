using System;

namespace Lab4
{
	public class Rectangle:Shape
	{
		
            private double width;
            private double height;

         public double Width{
                get{ return width;}
                set{ 
                    if(value > 0 ){
                        width =value;
                    }
                    else{
                        width =1;
                    }
                        }
            }
            public double Height{
            get{return height;}
            set{
                if(value > 0 ){
                        height =value;
                    }
                    else{
                        height = 1;
                    }
                }

        }


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

