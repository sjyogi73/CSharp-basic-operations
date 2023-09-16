using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_array
{
    class sortingProgram
    {
        static void Main(string[] args)
        {
            int a, b, n, temp = 0;
            Console.WriteLine("Enter the array length:");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine();
            Console.WriteLine("Enter array value one by one");
            for (int I = 0; I < arr.Length; I++)
            {
                arr[I] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (a = 0; a < arr.Length; a++)
            {
                for (b = a + 1; b < arr.Length; b++)
                {
                    if (arr[a] > arr[b])
                    {
                        temp = arr[a];
                        arr[a] = arr[b];
                        arr[b] = temp;

                    }
                }
                Console.WriteLine(arr[a]);
            }
            Console.ReadLine();
        }
    }
}
