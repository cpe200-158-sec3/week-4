using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Point
    {
        protected double x;
        protected double y;

        public double X {
            get {
                return x;
            }
            set {
                x = value;
            }
        }

        public double Y {
            get {
                return y;
            }
            set {
                y = value;
            }
        }

        public Point() {
            x = 0;
            y = 0;
        }

        public Point(Point p) {
            x = p.X;
            y = p.Y;
        }

        public Point(double a, double b) {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return "Point: " + X + "," + Y;
        }
    }
}
