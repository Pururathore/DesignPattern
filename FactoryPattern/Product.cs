using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    //Product
    //This is an interface for creating the objects.

    //ConcreteProduct
    //This is a class which implements the Product interface.

    //Creator
    //This is an abstract class and declares the factory method, which returns an object of type Product.

    //ConcreteCreator
    //This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.

    //C# - Implementation Code
    interface Product
    {
    }

    class ConcreteProductA : Product
    {
    }

    class ConcreteProductB : Product
    {
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod(string type);
    }

    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(string type)
        {
            switch (type)
            {
                case "A": return new ConcreteProductA();
                case "B": return new ConcreteProductB();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
