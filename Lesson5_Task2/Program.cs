using System;

namespace Lesson5_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMath operation = new MathProxy();

            operation.Add(1024, 128);
            operation.Subtract(512, 64);
            operation.Multiply(32, 8);
            operation.Divide(4096, 16);

            Console.ReadLine();
        }
    }

    public interface IMath
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
    }

    class Math : IMath
    {
        public int Add(int a, int b) { return a + b; }
        public int Subtract(int a, int b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
        public int Divide(int a, int b) { return a / b; }
    }

    class MathProxy : IMath
    {
        Math math;

        public int Add(int a, int b)
        {
            if (math == null)
                math = new Math();

            int c = math.Add(a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
            return c;
        }

        public int Subtract(int a, int b)
        {
            if (math == null)
                math = new Math();

            int c = math.Subtract(a, b);
            Console.WriteLine("{0} - {1} = {2}", a, b, c);
            return c;
        }

        public int Multiply(int a, int b)
        {
            if (math == null)
                math = new Math();

            int c = math.Multiply(a, b);
            Console.WriteLine("{0} * {1} = {2}", a, b, c);
            return c;
        }

        public int Divide(int a, int b)
        {
            if (math == null)
                math = new Math();

            int c = math.Divide(a, b);
            Console.WriteLine("{0} / {1} = {2}", a, b, c);
            return c;
        }
    }
}