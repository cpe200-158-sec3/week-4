using System;

namespace Lab401
{
	public class Cylinder:Circle
	{
        protected double height;

        public double Height
		{
            get
            {
                return height;
            }
            set
            {
                if (height >= 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Height >= 0");
                }
            }
		}

        public Cylinder()
        {
            height = 1.0;
        }

        public Cylinder(double r, double h) : base(r)
        {  
            height = h;  
        }  
        public Cylinder(double x, double y, double r, double h) : base(x, y, r)  
        {  
           height = h;  
        }  
        public Cylinder(Circle c) : base(c.x, c.y, c.radius)  
        {  
           height = 1.0;  
        }  
        public Cylinder(Cylinder cl) : base(cl.x, cl.y, cl.radius)  
        {  
            height = cl.height;  
        }  
        public double getArea()
        {  
            return 2 * Math.PI * (radius* height + Math.Pow(radius, 2));  
        }  
        public double getVolume()
        {  
            return Math.PI* Math.Pow(radius, 2) * height;  
        }  
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", x, y,radius, Height, getArea(), getVolume());
        }
    }
}

