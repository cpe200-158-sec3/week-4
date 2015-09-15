using System;

namespace Lab401
{
	public class Point
	{
        protected double _x, _y;

        public double x
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

        public double y
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

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            _x = p.x;
            _y = p.y;
        }

        public override string ToString()
        {
            return "center(" + x + "," + y + ")";
        }
    }
}

