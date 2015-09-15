using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Circle:Point
    {

       private double radius;
       //private double center;

        public double Radius {
            get { return radius; }
            set { if (value >= 0)
                {
                    radius = value;
                }
                else {
                    Console.WriteLine("Radius less than 0");
                } }
        }

        public Circle():base(0,0) {
           // x = 0;
           // y = 0;
            radius = 1;
        }

        public Circle(double radius) {
            this.radius =radius ;
        }

        public Circle(double x,double y,double radius):base(x,y) {
            //this.x = x;
            //this.y = y;
            this.radius = radius;
        }

        public Circle(Circle c):base(c.x,c.y) {
           // x = c.x;
           // y = c.y;
            radius = c.radius;
        }

        public void setCircle(double x,double y,double radius) {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public virtual Double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //[Circle: center(1.5,5), radius=2, area=12.5663706143592]

        public override string ToString()
        {
            return "[Circle: center("+x+","+y+"), radius= "+radius+", area="+getArea()+"]";
        }
    }
}
