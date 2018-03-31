using System;

namespace Lesson2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order firstOrder = new Order() { OrderId = 1, Name = "FirstOrder" };
            OrderRepository repository = new OrderRepository();
            RepositoryAPI repoApi = new RepositoryAPI();
            RepositoryMySQL repoMySQL = new RepositoryMySQL();

            repository.Save(firstOrder, repoApi);
            firstOrder = repository.Load(1, repoApi);

            repository.Save(firstOrder, repoMySQL);
            firstOrder = repository.Load(1, repoMySQL);
        }
    }

    class Order
    {
        int orderId;
        string name;

        public int OrderId { get => orderId; set => orderId = value; }
        public string Name { get => name; set => name = value; }
    }

    class OrderRepository
    {
        public Order Load(int orderId, IRepository rep)
        {
            return rep.Load(orderId);
        }
        public void Save(Order order, IRepository rep)
        {
            rep.Save(order);
        }
        public void Update(Order order, IRepository rep)
        {
            rep.Update(order);
        }
        public void Delete(Order order, IRepository rep)
        {
            rep.Delete(order);
        }
    }

    interface IRepository
    {
        Order Load(int orderId);
        void Save(Order order);
        void Update(Order order);
        void Delete(Order order);
    }

    class RepositoryMySQL : IRepository
    {
        public Order Load(int orderId)
        {
            throw new NotImplementedException();
        }
        public void Save(Order order) { }
        public void Update(Order order) { }
        public void Delete(Order order) { }
    }
    class RepositoryAPI : IRepository
    {
        public Order Load(int orderId)
        {
            throw new NotImplementedException();
        }
        public void Save(Order order) { }
        public void Update(Order order) { }
        public void Delete(Order order) { }
    }
}