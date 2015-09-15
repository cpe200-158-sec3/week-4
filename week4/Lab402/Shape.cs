using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab402
{
	public abstract class Shape
	{
        //abstract member
        public abstract double getArea();
        public abstract double getPerimeter();
     
        //concrete member
        public String _color;

        public String Color
        {
            get { return _color; }
        }

		public Shape (String c)
		{
            _color = c;            
		}

        public override string ToString()
        {
            return "[Shape: color="  + _color + "]";
        }
	}
}

