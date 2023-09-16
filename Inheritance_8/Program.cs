using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_8
{
    class inputprime

    {

        public void input()

        {

            Console.WriteLine("\nEnter the Number"); n = Int32.Parse(Console.ReadLine());

        }

        protected int n;

    }

    class outputprime : inputprime

    {

        int i, t = 0;

        public void output()

        {

            for (i = 2; i <= n - 1; i++)

            {

                if (n % i == 0)

                {

                    t = 1;

                }

            }

            if (t == 1)

            {

                Console.WriteLine("The Given Number " + n + " is Not a Prime");

            }

            else

            {

                Console.WriteLine("The Given Number " + n + " is a Prime");

            }

        }

    }

    class prime

    {

        static void Main(string[] args)

        {

            int input123 = 0;

            outputprime obj = new outputprime(); l:

            Console.WriteLine("\n\nIf you Start Press 1 , stop Press 0");


            try

            {

                input123 = int.Parse(Console.ReadLine());

            }

            catch

            {

                Console.WriteLine("Please give Correct Input"); goto l;

            }

            if (input123 != 0)

            {

                obj.input();

                obj.output(); goto l;

            }

        }

    }

}

