using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    //This is an interface for creating the objects.
    public interface IFactory
    {
        void Drive(int miles);
    }

    // A 'ConcreteProduct' class: This is a class which implements the Product interface.
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }
    // A 'ConcreteProduct' class: This is an abstract class and declares the factory method, which returns an object of type Product.
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }

    // The Creator Abstract Class: This is an abstract class and declares the factory method, which returns an object of type Product.
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }

    // A 'ConcreteCreator' class: This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }
    }
}
