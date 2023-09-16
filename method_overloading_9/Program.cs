using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_9
{
    class class1

    {

        public int sum(int A, int B)

        {

            return A + B;

        }

        public double sum(int A, double B)

        {

            return A + B;

        }

    }

    class class2 : class1

    {

        public int sum(int A, int B, int C)

        {

            return A + B + C;

        }

    }

    class Program

    {

        static void Main()

        {

            int a, b, c; double d;

            class2 obj = new class2();

            Console.WriteLine("enter the integer value for a and b:"); a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("sum of a+b=" + obj.sum(a, b));

            Console.WriteLine("enter the integer value for a and double value for b:"); a = Convert.ToInt32(Console.ReadLine());

            d = double.Parse(Console.ReadLine()); Console.WriteLine("sum of a+b=" + obj.sum(a, d)); Console.ReadLine();

            Console.WriteLine("enter the integer value for a,b and c:"); a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine()); c = int.Parse(Console.ReadLine());


            Console.WriteLine("sum of a+b+c=" + obj.sum(a, b, c)); Console.ReadLine();

        }

    }

}

