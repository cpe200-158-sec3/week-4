using System;

namespace Lab401
{
	public class Circle :Point
	{
        protected double _radius;
        
        public double radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    Console.WriteLine("Redius >= 0");
                }
            }
        }

        public Circle() : base (0,0)
        {
            _radius = 1.0;
        }

        public Circle(double r) : base(0,0)
        {
            _radius = r; 
        }

        public Circle(double x, double y, double r) : base(x, y)
        {  
            _radius = r;  
        }  
        public Circle(Circle c) : base(c.x, c.y)  
        {  
            _radius = c.radius;  
        }  
        public void setCircle(double x, double y, double r)
        {
            base._y = y;
            base._x = x;
            _radius = r;  
             
        }  
        public double getArea()
        {  
            return Math.PI* Math.Pow(radius, 2);  
        }  
        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}]", x, y, radius, getArea());
        }  
	}
}

