using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array_6
{
    class Program
    {
        public static void Main()

        {

            int[][] myjag = new int[3][]; for (int i = 0; i < myjag.Length; i++)

            {

                myjag[i] = new int[i + 3];

            }



            for (int i = 0; i < 3; i++)

            {

                Console.WriteLine("Enter the Elements of row{0}:", i); for (int j = 0; j < myjag[i].Length; j++)

                {

                    myjag[i][j] = int.Parse(Console.ReadLine());

                }

            }



            int sum = 0;

            for (int i = 0; i < 3; i++)

            {

                for (int j = 0; j < myjag[i].Length; j++)

                {

                    sum += myjag[i][j];

                }

            }

            Console.WriteLine("sum=" + sum); Console.Read();

        }
    }
}
