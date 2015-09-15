using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    class Cylinder:Circle
    {
        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Height less than 0");
                }
            }
        }

        public Cylinder():base(0,0,1) {
            //x = 0;
           // y = 0;
           // Radius = 1;
            height = 1;
        }

        public Cylinder(double radius,double height):base(radius) {
           // this.Radius = radius;
            this.height = height;
        }

        public Cylinder(double x,double y,double radius,double height):base(x,y,radius) {
            //this.x = x;
            //this.y = y;
            //this.Radius = radius;
            this.height = height;
        }

        public Cylinder(Circle c):base(c.x,c.y,c.Radius) {
            height = 1;
            //x = c.x;
            //y = c.y;
            //Radius = c.Radius;
        }

        public Cylinder(Cylinder cy) {
            x = cy.x;
            y = cy.y;
            Radius = cy.Radius;
            height = cy.height;
        }

        public override Double getArea() {
            return 2 * (Math.PI * Math.Pow(Radius, 2)) + (2 * Math.PI * Radius * height);
        }

        public double getVolume() {
            return Math.PI * Math.Pow(Radius, 2) * height;
        }

       // [Cylinder: center(1, 1), radius=3, height=4, surface=131.946891450771, volume=113.097335529233]
        public override string ToString()
        {
            return "[Cylinder: center("+x+","+y+"), radius="+Radius+", height="+height+", surface="+getArea()+", volume="+getVolume()+"]";
        }
    }
}
