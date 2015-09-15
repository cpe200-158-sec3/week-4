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


        public double X {
            get { return x; }
            set { x = value; }
        }

        public double Y {
            get { return y; }
            set { y = value; }
        }

        public Point() {
            this.x = 0;
            this.y = 0;
        }

        public Point(Point p) {
            this.x = p.x;
            this.y = p.y;
        }

        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return " ";
        }

    }
}
