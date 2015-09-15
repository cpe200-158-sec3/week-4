using System;

namespace Lab401
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
            x = 0;
            y = 0;
            }
        
        public Point(double x, double y)
       {
            this.x = x;
            this.y = y;
        }
        public Point(Point z)
        {
            x = z.x;
            y = z.y;
        }
        public override string ToString()
        {
            return "center (" + this .x + ", " +this. y + ")";
        }
    }
}