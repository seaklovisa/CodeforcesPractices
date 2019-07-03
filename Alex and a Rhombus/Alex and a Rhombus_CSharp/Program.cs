using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alex_and_a_Rhombus_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.Compute(Convert.ToInt32(Console.ReadLine())));
        }
    }

    class Solution
    {
        public static int Compute(int n)
        {
            int last = n * 2 - 1;
            return (1 + last) * n - last;
        }
    }
}
