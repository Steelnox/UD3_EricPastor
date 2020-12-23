using System;

namespace UD3_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 2;
            int C = 3;
            int D = 4;

            Console.WriteLine("Valores iniciales");
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("C = {0}", C);
            Console.WriteLine("D = {0}", D);

            B = C;
            C = A;
            A = D;
            D = B;

            Console.WriteLine("Valores finales");
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("C = {0}", C);
            Console.WriteLine("D = {0}", D);

        }
    }
}
