using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_12
{
    class Program

    {
        static int m = 10; static int n = 0; static void division()

        {

            try

            {

                int k = m / n;

            }

            catch (ArgumentException e)

            {

                Console.WriteLine("exception caught:" + e.Message);

            }

            finally

            {

                Console.WriteLine("inside division method"); Console.ReadLine();

            }

        }

        static void Main()

        {

            try

            {

                division();

            }

            catch (DivideByZeroException e)

            {

                Console.WriteLine("exception caught:" + e.Message);

            }

            finally

            {

                Console.WriteLine("inside main method"); Console.ReadLine();

            }

        }
    }
}
