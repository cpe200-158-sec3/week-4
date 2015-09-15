using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB401
{
    class Cylinder : Circle
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
                if (value >= 0)
                {

                    height = value;
                }
                else
                {
                    Console.WriteLine("The radius must be at least 0");
                }
            }
        }
        public Cylinder()
            : base(0,0,1)
        {
            height = 1.0;
        }
        public Cylinder(double height ,double radius)
           : base(0, 0,radius )
        {
            Radius = radius;
            Height = height;
        }
        public Cylinder(double x,double y,double radius, double height)
           : base(x,y,radius)
        {
           
            Height = height;
        }

        public Cylinder (Circle a)
            :base(a.X,a.Y,a.Radius)
        {
            Height = 1.0;
        }

       public Cylinder (Cylinder a)
             : base(a.X, a.Y, a.radius)
        {
           
            Height = a.height;
           // Console.WriteLine(a+"aaa");
            
        }
        public override double getArea()
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
        }

        public double Volume ()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override string ToString()
        {
           return string.Format(" [Cylinder: center({0}, {1}), radius={2}, height={3}, surface={4}, volume={5}] ",X,Y,Radius,Height,getArea(),Volume()) ;

    }
}
}
