using System;

namespace Lab4
{
	public abstract class Shape
	{
        private double _Width;
        private double _Height;

        public double Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value > 0)
                {
                    _Width = value;
                }
                else
                {
                    _Width = 1;
                }
            }
        }

        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (value > 0)
                {
                    _Height = value;
                }
                else
                {
                    _Height = 1;
                }
            }
        }
        private readonly string _Color = "gold";
        public string Color
        {
            get 
            {
                return _Color;
            }
        }
		public Shape (string color)
		{
            _Color = color;
		}

        public abstract double getArea();
        public abstract double getPerimeter();

        public override string ToString()
        {
            return "";
        }



	}
}

