using System;

namespace Lab402
{
	public abstract class Shape
	{
        private readonly string _color = "gold";
        protected double _width, _height;
        public string color
        {
            get
            {
                return _color;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1;
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if(value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1;
                }
            }
        }

		public Shape (string c)
		{
            _color = c;
        }

        public abstract double getArea();  
        public abstract double getPerimeter();


        public override string ToString()
        {
            return _color; 
        }
    }
}

