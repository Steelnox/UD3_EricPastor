using System;

namespace UD3_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            double A = 200;
            char C = 'b';

            Console.WriteLine("Variable N = {0}", N);
            Console.WriteLine("Variable A = {0}", A);
            Console.WriteLine("Variable C = {0}", C);

            Console.WriteLine("{0} + {1} = {2}", N, A, N + A);
            Console.WriteLine("{0} - {1} = {2}", A, N, A - N);
            Console.WriteLine("Valor numérico del carácter {0} = {1}", C, (int)C);

        }
    }
}
