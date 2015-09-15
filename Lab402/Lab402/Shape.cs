﻿using System;
 
namespace Lab4
{
	public abstract class Shape
    {
        protected readonly string color = "gold";
        public Shape(string c)
        {
            color = c;
        }
        public override string ToString()
        {
            return color;
        }
        public abstract double getArea();
        public abstract double getPerimeter();
    }
}

