using System;
using System.Threading;

namespace Lesson4_Task1
{
    public class Singleton
    {
        public int threadTest = 0;

        private static Singleton _instance;
        private static Object _locker = new Object();

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }
                //_instance = new Singleton();
            }
            return _instance;
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