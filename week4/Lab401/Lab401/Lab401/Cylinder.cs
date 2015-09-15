using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Cylinder:Circle
    {
        protected double height;
        public double Height
        {
            get { return height; }
            set {
                if (value >= 0) { height = value; }
                else { Console.WriteLine("Error Height must be at least 0"); }
            }
        }

        public Cylinder()
            :base(0,0,1)

        {
            height = 1;
        }

        public Cylinder(double rad, double height):base(0,0,rad)       
        {
            this.height = height; 
        }

        public Cylinder(double x, double y, double rad, double height)
            : base(x, y, rad)
        {
            this.height = height;
        }

        public Cylinder(Circle c)
            : base(c)
        {
            height = 1;
        }
        public Cylinder(Cylinder c):base(c.X,c.Y,c.Radius)
        {
            height = c.Height;
          
        }
        public override double getArea()
        {
            return base.getArea()*2 + 2*Math.PI*base.Radius*Height ;
        }

        public double getVolume()
        {
            return base.getArea() * Height;
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]",base.X,base.Y,base.Radius,Height,getArea(),getVolume());
        }
    }
}
