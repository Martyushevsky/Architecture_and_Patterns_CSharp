using System;

namespace Lesson7_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            ShippingCostCalculator shippingCostCalculator = new ShippingCostCalculator();

            Console.WriteLine(shippingCostCalculator.Calculate(order, new EmsStrategy()));
            Console.WriteLine(shippingCostCalculator.Calculate(order, new UpsStrategy()));
            Console.WriteLine(shippingCostCalculator.Calculate(order, new FedexStrategy()));

            Console.ReadLine();
        }
    }

    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }

    public class ShippingCostCalculator
    {
        public double Calculate(Order order, IShippingStrategy shippingStrategy)
        {
            return shippingStrategy.Calculate(order);
        }
    }

    public class EmsStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 3;
        }
    }

    public class UpsStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 4;
        }
    }

    public class FedexStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 5;
        }
    }

    public class Address
    {
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }

    public class Order
    {
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }
}