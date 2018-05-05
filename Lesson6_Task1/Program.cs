using System;

namespace Lesson6_Task1
{
    class Program
    {
        private static Manager GetChainOfCommand()
        {
            Manager chief = new DepartmentChief("Dmitry Lesnoy");
            Manager executive = new CompanyExecutive("Vasily Elkin");

            chief.HigherUp = executive;

            return chief;
        }

        static void Main(string[] args)
        {
            Manager manager = GetChainOfCommand();

            manager.HandleRequest(500);
            manager.HandleRequest(50_000);

            Console.ReadLine();
        }
    }

    abstract class Manager
    {
        public string Name { get; set; }
        public Manager HigherUp { get; set; }

        public abstract void HandleRequest(int condition);

        public void Respond()
        {
            Random r = new Random();

            if (r.Next(2) == 1)
            {
                Console.WriteLine($"Granted. {Name}.");
            }
            else
            {
                Console.WriteLine($"Prohibited. {Name}.");
            }
        }
    }

    class DepartmentChief : Manager
    {
        public DepartmentChief(string name)
        {
            Name = name;
        }

        public override void HandleRequest(int condition)
        {
            if (condition <= 10_000)
            {
                Respond();
            }
            else if (HigherUp != null)
            {
                HigherUp.HandleRequest(condition);
            }
        }
    }

    class CompanyExecutive : Manager
    {
        public CompanyExecutive(string name)
        {
            Name = name;
        }

        public override void HandleRequest(int condition)
        {
            if (condition > 10_000)
            {
                Respond();
            }
            else if (HigherUp != null)
            {
                HigherUp.HandleRequest(condition);
            }
        }
    }
}