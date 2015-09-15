using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Point
    {
        public double x;
        public double y;

        public Point()
        {
            x = 0;
            y = 0;

        }

        public Point(Point a)
        {
          x = a.x;
          y = a.y;

        }

        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return (" ");
        }







    }
}
