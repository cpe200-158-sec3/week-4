using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab401
{
    class Point
    {
         protected double x,y;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Point()
        {
           this.x = 0;
            this.y = 0;
        }
        public Point(Point a)
        {
            x = a.x;
            y = a.y;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "center (" + this.x + ", " + this.y + ")";
        }
    }
}
