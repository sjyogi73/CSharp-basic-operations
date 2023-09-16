using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_class_11
{
    interface addition

    {

        int add();

    }

    interface multiplication

    {

        int multiply();

    }

    class compute : addition, multiplication

    {

        int x, y;

        public compute(int a, int b)

        {

            this.x = a; this.y = b;

        }

        public int add()

        {

            return (x + y);

        }

        public int multiply()

        {

            return (x * y);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            int a, b;

            Console.Write("enter the two numbers: "); a = Convert.ToInt32(Console.ReadLine()); b = Convert.ToInt32(Console.ReadLine()); compute ob1 = new compute(a, b);

            Console.WriteLine("addition is:" + ob1.add()); Console.WriteLine("multiplication is:" + ob1.multiply()); Console.ReadLine();

        }

    }
}
