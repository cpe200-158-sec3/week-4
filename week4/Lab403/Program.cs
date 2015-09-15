using System;
 
namespace Lab403
{

  class MainApp
  {

    static void Main()
    {
			Console.WriteLine ("--------- Design#1 ---------");
      		testDesign1 ();
			Console.WriteLine ("\n--------- Design#2 ---------");
			testDesign2 ();
    }

	static void testDesign1() {
		// An array of creators
		Creator[] creators = new Creator[2];

		creators[0] = new ConcreteCreatorA();
		creators[1] = new ConcreteCreatorB();

		// Iterate over creators and create products
		foreach (Creator creator in creators)
		{
			Product product = creator.FactoryMethod();
			Console.WriteLine("Created {0}", product.GetType().Name);
		}

		// Wait for user
		Console.ReadKey();
  	}

  	static void testDesign2() {
		// Configure Observer pattern
		ConcreteSubject s = new ConcreteSubject();

		s.Attach(new ConcreteObserver(s, "X"));
		s.Attach(new ConcreteObserver(s, "Y"));
		s.Attach(new ConcreteObserver(s, "Z"));

		// Change subject and notify observers
		s.SubjectState = "ABC";
		s.Notify();

		// Wait for user
		Console.ReadKey();
  	}
  }


  
}

