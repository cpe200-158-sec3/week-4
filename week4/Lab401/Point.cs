using System;

namespace Lab401
{
	public class Point
	{
        private double _x, _y;
        public double x
        {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Point()
		{
            _x = 0;
            _y = 0;
		}
        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
        public Point(Point p)
        {
            _x = p.x;
            _y = p.y;
        }
        public override string ToString()
        {
            return "center(" + _x + "," + _y + ")";
        }
    }
}

