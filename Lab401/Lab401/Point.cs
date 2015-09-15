using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    public class Point
    {
        private double _x;
        private double _y;

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public Point()
        {
            _x = 0;
            _y = 0;
        }
        public Point(Point p)
        {
            this._x = p.X;
            this._y = p.Y;
        }
        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
        public override string ToString()
        {
            return "center(" + _x + "," + _y + ")";
        }
    }
}
