using System;

namespace UD3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 100;
            int Y = 4;

            double N = 1000;
            double M = 5500;

            Console.WriteLine("Variable X = {0}", X);
            Console.WriteLine("Variable Y = {0}", Y);
            Console.WriteLine("Variable N = {0}", N);
            Console.WriteLine("Variable M = {0}", M);

            Console.WriteLine("{0} + {1} = {2}", X, Y, X + Y);
            Console.WriteLine("{0} - {1} = {2}", X, Y, X - Y);
            Console.WriteLine("{0} * {1} = {2}", X, Y, X * Y);
            Console.WriteLine("{0} / {1} = {2}", X, Y, X / Y);
            Console.WriteLine("El residuo de {0} y {1} = {2}", X, Y, X % Y);

            Console.WriteLine("{0} + {1} = {2}", N, M, N + M);
            Console.WriteLine("{0} - {1} = {2}", N, M, N - M);
            Console.WriteLine("{0} * {1} = {2}", N, M, N * M);
            Console.WriteLine("{0} / {1} = {2}", N, M, N / M);
            Console.WriteLine("El residuo de {0} y {1} = {2}", N, M, N % M);

            Console.WriteLine("{0} + {1} = {2}", X, N, X + N);
            Console.WriteLine("{0} / {1} = {2}", Y, M, Y / M);
            Console.WriteLine("El residuo de {0} y {1} = {2}", Y, M, Y % M);

            Console.WriteLine("El doble de {0} es {1}", X, 2 * X);
            Console.WriteLine("El doble de {0} es {1}", Y, 2 * Y);
            Console.WriteLine("El doble de {0} es {1}", N, 2 * N);
            Console.WriteLine("El doble de {0} es {1}", M, 2 * M);

            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", X, Y, N, M, X + Y + N + M);
            Console.WriteLine("{0} * {1} * {2} * {3} = {4}", X, Y, N, M, X * Y * N * M);


        }
    }
}
