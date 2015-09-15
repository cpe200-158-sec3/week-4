﻿using System;


namespace Lab4
{
    public class Point
    {
        public double x
        {
            get;
            set;
        }
        public double y
        {
            get;
            set;
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