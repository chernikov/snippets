using System;

namespace StaticApp
{
    class Program
    {
        static void Main(string[] args)
        {
            D.Method();
            
            var d = new D();
            var d2 = new D();
        }
    }


    public class D {
        static D() {
            Console.WriteLine("Static D");
            throw new Exception();
        }


        public D() {
            Console.WriteLine("CTOR D");
        }

        public static void Method() {
            Console.WriteLine("Call method");
        }

    }
}
