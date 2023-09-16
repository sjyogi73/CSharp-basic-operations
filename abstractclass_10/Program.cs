using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass_10
{
    abstract class test

    {

        public int a = 5;

        public abstract void A();

    }

    class derived1 : test

    {

        public override void A()

        {

            Console.WriteLine("Derived1 A"); base.a++; Console.WriteLine("a={0}", base.a);

        }

    }

    class derived2 : test

    {

        public override void A()

        {

            Console.WriteLine("Derived2 A"); base.a--; Console.WriteLine("a={0}", base.a);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            derived1 t1 = new derived1(); t1.A();

            derived2 t2 = new derived2(); t2.A();

            Console.ReadLine();

        }

    }
}
