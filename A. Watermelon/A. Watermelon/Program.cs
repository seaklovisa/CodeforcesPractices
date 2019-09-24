using System;

namespace A._Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine( (weight %  2 == 0&& weight > 2) ? "YES" : "NO");
        }
    }
}
