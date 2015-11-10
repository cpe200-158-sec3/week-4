using System;

namespace Lab4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Shape s1 = new Rectangle("red", 4, 5);
			Console.WriteLine (s1);
			Console.WriteLine ("Area is " + s1.getArea());

			Shape s2 = new Triangle("blue", 4, 5);
			Console.WriteLine (s2);
			Console.WriteLine ("Area is " + s2.getArea());

			// Cannot create instance of an abstract class - Compilation Error!!
			//      Shape s3 = new Shape("green");
		}
	}
}
