using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 2, eps;
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());
            eps = Convert.ToDouble(Console.ReadLine());

            double x, xz;

            if (f(a) * SecondDerivative(a) > 0)
                xz = a;
            else xz = b;

            x = xz;

            while (Math.Abs(f(x)) > eps)
            {
                x -= f(x) / FirstDerivative(xz);

            }

            Console.WriteLine("f(x) = {0:##.###########}", f(x));
        }

        static double f(double x)
        {
            return (Math.Cos(2 / x) - 2 * Math.Sin(1 / x) + 1 / x);
        }

        static double FirstDerivative(double x)
        {
            return (2 * (Math.Sin(2 / x) + Math.Cos(1 / x) + 1)) / (x * x);
        }

        static double SecondDerivative(double x)
        {
            return -((4 * Math.Sin(2 / x) + 4 * Math.Cos(1 / x) + 4) * x + 4 * Math.Cos(2 / x) - 2 * Math.Sin(1 / x)) / (x * x * x * x); 
        }

    }
}
