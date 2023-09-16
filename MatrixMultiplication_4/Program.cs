using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        public static void Main(String[] Args)
        {
            int[,] a = new int[5, 5];
            int[,] b = new int[5, 5];

            int[,] c = new int[10, 10];
            int m, n, i, j, p, q, k;
            Console.WriteLine("Enter the order of first matrix");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the order of Second matrix");
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            if (n != p)
            {
                Console.WriteLine("not possible");
            }
            else
            {
                Console.WriteLine("Enter any array element of First Matrix");

            }
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = int.Parse(Console.ReadLine());
            Console.WriteLine("enter array elements of second matrix");
            for (i = 0; i < p; i++)
                for (j = 0; j < q; j++)
                    a[i, j] = int.Parse(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < q; j++)
                {
                    c[i, j] = 0;
                    for (k = 0; k < n; k++)
                        c[i, j] = c[i, j] + a[i, k] * b[k, j];

                }
            }
            Console.WriteLine("result of multiply");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < q; j++)
                    Console.Write("\t" + c[i, j]);
                Console.WriteLine();

            }

        }

    }
}