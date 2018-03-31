using System;
using System.Collections.Generic;

namespace Lesson1_Task2
{
    class Task2
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;

        private static string GenerateInfo(string name, string description, int age)
        {
            return String.Format(Format, name, description, Address, age);
        }

        #region DummyFuncs

        private static string DummyFunc()
        {
            return GenerateInfo("Петя", "школьный друг", 30);
        }

        private static string DummyFuncAgain()
        {
            return GenerateInfo("Вася", "сосед", 54);
        }

        private static string DummyFuncMore()
        {
            return GenerateInfo("Николай", "сын", 4);
        }

        #endregion        

        private static List<Func<string>> GetActionSteps()
        {
            return new List<Func<string>>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }

        private static void ExecuteFunction(Func<string> function)
        {
            string methodName = function.Method.Name;
            Console.WriteLine("Начало работы метода {0}", methodName);
            Console.WriteLine(function());
            Console.WriteLine("Окончание работы метода {0}\n", methodName);
        }

        static void Main(string[] args)
        {
            List<Func<string>> functions = GetActionSteps();

            foreach (var function in functions)
            {
                ExecuteFunction(function);
            }

            Console.ReadLine();
        }
    }

    public static class Constants
    {
        public static readonly string Address = "Москва, Россия";
        public static readonly string Format = "{0} - {1}, адрес {2}, возраст {3}";
    }
}