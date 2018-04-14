using System;
using System.Threading;

namespace Lesson4_Task2
{
    public class Singleton
    {
        public int threadTest = 0;

        private static Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton GetInstance()
        {
            return lazy.Value;
        }

        public void Test()
        {
            threadTest++;
        }

        private Singleton() { }
    }

    class Program
    {
        static void NewThread()
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.Test();
            Console.WriteLine("{0}", singleton.threadTest);
        }

        static void Main(string[] args)
        {
            var threads = new Thread[10];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(NewThread);
                threads[i].Start();
            }

            Console.ReadKey();
        }
    }
}