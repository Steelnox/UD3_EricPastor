using System;

namespace UD3_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 2;
            Console.WriteLine("{0} + 77 = {1}", N, N += 77);
            Console.WriteLine("{0} - 3 = {1}", N, N -= 3);
            Console.WriteLine("{0} * 2 = {1}", N, N *= 2);
        }
    }
}
