using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Point
    {
        protected double X;
        protected double Y;
        public double x
        {
            get { return X; }
            set
            {
                X = value;
            }
        }
        public double y
        {
            get { return Y; }
            set
            {
                Y = value;
            }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y; 
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
