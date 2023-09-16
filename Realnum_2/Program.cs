using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class meanMedian
    {
        static void Main(string[] args)
        {
            float[] x = new float[10];
            int i, n;
            double avrg, var, SD, sum = 0, sum1 = 0;
            Console.WriteLine("Enter the value of N");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} real numbers", n);
            for (i = 0; i < n; i++)
            {
                x[i] = float.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                sum = sum + x[i];
            }
            avrg = sum / (float)n;
            for (i = 0; i < n; i++)
            {
                sum1 = sum1 + Math.Pow((x[i] - avrg), 2);
            }
            var = sum1 / (float)n;
            SD = Math.Sqrt(var);
            Console.WriteLine("\n Mean of all elements={0}\n", avrg);
            Console.WriteLine("Variance of all elements={0}\n", var);
            Console.WriteLine("Standard Deviation={0}\n", SD);
            Console.ReadLine();

        }
    }
}