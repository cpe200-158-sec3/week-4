using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Circle : Point
    {
        private double _radius;
        public double radius
        {
            get { return _radius; }
            set
            {
                if (value >= 0)
                {

                    _radius = value;

                }
                else
                {
                    _radius = 1;

                }
             }
        }

        public Circle():base(0,0)
        {
      
            radius = 1;
        }

        public Circle(double r):base(0,0)
        {
            radius = r;
        }

        public Circle(double x,double y,double radius):base(x,y)
        {
            
            this.radius = radius;
        }

        public Circle(Circle v):base(v.x,v.y)
        {
           radius = v.radius;
        }

        public void setCircle(double x,double y,double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;

        }

        public virtual double getAge()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}]",x,y,radius,getAge());
        }






















    }
}
