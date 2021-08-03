using System;
using System.Threading;

namespace ParametersGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mc = new MainClass();
            var result = mc.Sum(mc.Calc1(), mc.Calc2());
            var result2 = mc.Sum(mc.Calc1, mc.Calc2);
        }
    }

    public class MainClass {
        public int Calc1() {
            Console.WriteLine("Calculate 1");
            return 1;
        }

        public int Calc2() {
            Console.WriteLine("Calculate 2");
            return 2;
        }

        public int Sum(int a, int b) {
            Console.WriteLine("A + B = ");
            var c = a + b;
            Console.WriteLine($"C = {c}");
            return c;
        }

        public int Sum(Func<int> a, Func<int> b) {
            Console.WriteLine("A + B = ");
            var c = a() + b();
            Console.WriteLine($"C = {c}");
            return c;
        }
    }
}
