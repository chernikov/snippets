
using System;

namespace LessonV2
{

    public class A : IHaveMethod
    {


        private class A1
        {

        }



        public void Method()
        {
            var a = new A1();
        }
    }


    public abstract class B : IHaveMethod
    {
        public abstract void Method();

        public virtual void Method1()
        {
        }
    }


    public class B1 : B, IHaveMethod
    {
        public override void Method()
        {
            Console.WriteLine("Musysh!!");
        }

        public override void Method1()
        {
            Console.WriteLine("Якщо хочеш!!");
        }
    }

    public class C : IHaveMethod
    {
        protected C()
        {

        }


        public virtual void Method()
        {

        }
    }

    public class C1 : IHaveMethod
    {
        public C1()
        {

        }


        public virtual void Method()
        {

        }
    }


    public interface IHaveMethod
    {
        void Method();
    }


    public interface IHaveMethod1 : IHaveMethod
    {
        void Method1();

        int B { get; set; }

    }


    public static class Program
    {
        public static void Main()
        {
            var c = new C1();
        }
    }

    public class D {
        
    }
    
}