using System;

namespace Lab4
{
	public abstract class Shape
	{
		  protected readonly string color = "gold" ;

          public string Color{
                get{ return color;}
            }
          public Shape(string c)
          {
                 color = c;

            }

          protected double width;
          protected double height;
          public double Width
          {
              get { return width; }
              set
              {
                  if (value > 0)
                  {
                      width = value;
                  }
                  else
                  {
                      width = 1;
                  }
              }
          }
          public double Height
          {
              get { return height; }
              set
              {
                  if (value > 0)
                  {
                      height = value;
                  }
                  else
                  {
                      height = 1;
                  }
              }

          }



          public override string ToString()
          {
              return color;
          }
            
            
            public abstract double getArea();
            public abstract double getPerimeter();


   

		
	}
}

