using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Cylinder : Circle
    {
        private double Heigh;
        public double heigh
        {
            get { return Heigh; }
            set
            {
                if (value >= 0)
                {

                    Heigh = value;

                }
                else
                {
                    Heigh = 1;

                }
            }
        }

        public Cylinder():base(0,0,1)
        {
            heigh = 1;
        }

        public Cylinder(double radius, double heigh):base(0,0,radius)
        {
           
            y = heigh;

        }

        public Cylinder(double x, double y, double radius, double heigh):base(x,y,radius)
        {
           this.heigh = heigh;
        }

        public Cylinder(Circle g):base(g.x,g.y,g.radius)
        {
            heigh = 1;
        }

        public Cylinder(Cylinder c):base(c.x,c.y,c.radius)
        {
            heigh = c.heigh;

        }

        public virtual double getArea()
        { 
            return 2 * Math.PI * radius*radius + 2 * Math.PI * radius * heigh;
        }

        public virtual double getVolume()
        {
            return  Math.PI * radius *radius* heigh;
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", x, y, radius, heigh,getArea(),getVolume());
        }


    }
}
