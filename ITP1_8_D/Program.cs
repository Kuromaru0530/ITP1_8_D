using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_8_D
{
    class Program
    {
        static void Main()
        {
            var s = Console.ReadLine();
            var p = Console.ReadLine();
            var s2 = s+s;

            if (s2.Contains(p)) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }
}