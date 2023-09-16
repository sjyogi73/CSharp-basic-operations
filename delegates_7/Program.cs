using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_7
{
    delegate string StrMod(string str); class DelegateTest

    {

        static string ReplaceSpaces(string s)

        {

            Console.WriteLine("Replacing spaces with hyphens."); return s.Replace(' ', '-');

        }

        static string RemoveSpaces(string s)

        {

            string temp = ""; int i;

            Console.WriteLine("Removing spaces."); for (i = 0; i < s.Length; i++)

                if (s[i] != ' ') temp += s[i]; return temp;

        }

        static string Reverse(string s)

        {

            string temp = ""; int i, j;

            Console.WriteLine("Reversing string."); for (j = 0, i = s.Length - 1; i >= 0; i--, j++) temp += s[i];

            return temp;

        }

        static void Main()

        {

            StrMod strOp = new StrMod(ReplaceSpaces); string str;

            str = strOp("This is a test."); Console.WriteLine("Resulting string: " + str); Console.WriteLine();

            strOp = new StrMod(RemoveSpaces); str = strOp("This is a test.");

            Console.WriteLine("Resulting string: " + str); Console.WriteLine();

            strOp = new StrMod(Reverse); str = strOp("This is a test.");

            Console.WriteLine("Resulting string: " + str); Console.ReadLine();

        }
    }
}
