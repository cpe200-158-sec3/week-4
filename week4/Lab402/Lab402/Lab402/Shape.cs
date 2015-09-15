using System;

namespace Lab402
{
	public abstract class Shape
	{
        private readonly string color="gold";

        public string Color {
            get { return color; }
            //set { color = "gold";}
        }

       
		public Shape (string color)
		{
            this.color = color;
		}

        public abstract double getArea();
        public abstract double getPerimeter();

         public override string ToString()
         {
             return "";
         }

    }
}

