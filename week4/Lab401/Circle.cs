using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB401
{
    class Circle : Point
    {
        protected double radius;
        protected Point center;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else {
                    Console.WriteLine("The radius must be at least 0")
                     ;
                }
            }
        }

        public Point Center
        {
            get
            {
                return center;
            }
            
        }


        public Circle()
            :base(0,0)
        {
            radius = 1.0;
            
        }

        public Circle(double radius)
            : base(0, 0)
        {
            Radius = radius; 
        }

        public Circle(double x ,double y ,double radius)
           : base(x, y)
        {
            Radius = radius;
        }

        public Circle(double x, double y, double radius ,Point P)
           : base(x, y)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public Circle (Circle a)
             : base(a.x, a.y)
        {
            Radius = a.radius;
        }

        public void setCircle(double x, double y, double radius)
        {
            center.X = x;
            center.Y = y;
            Radius = radius;
        }
        public virtual double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return string.Format("Circle: center({0},{1}), radius={2}, area {3}]",X,Y,radius,getArea() );
        }
    }
}
