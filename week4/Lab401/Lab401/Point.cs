using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Point
    {
        private double x, y;
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
        public Point(Point p)
        {
            x = p.X;
            y = p.Y;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
