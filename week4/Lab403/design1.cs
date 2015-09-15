using System;

namespace Lab403
{
	/// <summary>
	/// The 'Product' abstract class
	/// </summary>
	abstract class Product
	{
	}

	/// <summary>
	/// A 'ConcreteProduct' class
	/// </summary>
	class ConcreteProductA : Product
	{
	}

	/// <summary>
	/// A 'ConcreteProduct' class
	/// </summary>
	class ConcreteProductB : Product
	{
	}

	/// <summary>
	/// The 'Creator' abstract class
	/// </summary>
	abstract class Creator
	{
		public abstract Product FactoryMethod();
	}

	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	class ConcreteCreatorA : Creator
	{
		public override Product FactoryMethod()
		{
		  return new ConcreteProductA();
		}
	}

	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	class ConcreteCreatorB : Creator
	{
	public override Product FactoryMethod()
		{
		  return new ConcreteProductB();
		}
	}
}

