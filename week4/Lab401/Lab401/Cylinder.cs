using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Cylinder: Circle
    {
        private double _Height;
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value >= 0)
                {
                    _Height = value;
                }
                else
                {
                    _Height = 1;
                }
            }
        }

         public Cylinder():base(0,0,1) {
            
            Height = 1;
        }

         public Cylinder(double r, double h):base(0,0,r) {
             
             Height = h;
         }

         public Cylinder(double x, double y, double r, double h):base(x,y,r) {
           
             Height = h;
         }

         public Cylinder(Circle c):base(c.x,c.y,c.radius) {
            
             Height = 1;
         }

         public Cylinder(Cylinder cy)
             : base(cy.x, cy.y, cy.radius)
         {
            
             Height = cy.Height;
         }

         public override double getArea()
         {
             return 2 * Math.PI * radius * radius + 2 * Math.PI * radius * Height;
         }

         public double getVolume() {
             return Math.PI * radius * radius * Height;
         }

         public override string ToString() {

             return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", x, y, radius, Height, getArea(), getVolume());
         }
    }
}
