using System;

namespace Lesson1_Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Store store = new Store(new DefaultIdGenerator());
            Customer customer = new Customer(new DefaultIdGenerator());
            Console.WriteLine("{0}-й магазин.\n{1}-й покупатель.", store.Id, customer.Id);
            Console.ReadLine();
        }
    }

    public interface IIdGenerator
    {
        long CalculateId();
    }

    public class DefaultIdGenerator : IIdGenerator
    {
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }

    public abstract class EntityBase
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }

        public EntityBase(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }
    }

    public class Customer : EntityBase
    {
        public string Description { get; set; }

        public Customer(IIdGenerator idGenerator) : base(idGenerator)
        {
        }
    }

    public class Store : EntityBase
    {
        public Store(IIdGenerator idGenerator) : base(idGenerator)
        {
        }
    }
}