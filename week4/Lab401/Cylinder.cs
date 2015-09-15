using System;

namespace Lab4
{
    class Cylinder:Circle
    {
        private double heigh;
        private Circle C = new Circle();
        private double Heigh { set { heigh = value; } get { return heigh; } }
        public Cylinder()
        {
            Heigh = 1;
            C = new Circle();
        }
        public Cylinder(double r,double h)
        {
            C = new Circle(r);
            Heigh = h;
        }
        public Cylinder(double x, double y, double r, double h)
        {
            C = new Circle(x,y,r);
            Heigh = h;
        }
        public Cylinder(Circle c)
        {
            C = c;
            Heigh = 1;
        }
        public Cylinder(Cylinder v)
        {
            C = v.C;
            Heigh = v.Heigh;
        }
        public override double getArea()
        {
            return (2*Math.PI*C.Radius*Heigh)+2*C.getArea();
        }
        public double getVolume()
        {
            return C.getArea() * Heigh;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: {0}, radius={1}, height={2}, surface={3}, volume={4}]",C.center,C.Radius,Heigh,getArea(),getVolume());
        }
    }
}
