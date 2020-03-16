using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, x;

            Console.WriteLine("Input x and k: ");
            x = Convert.ToDouble(Console.ReadLine());
            k = Convert.ToDouble(Console.ReadLine());

            double sum = 1, prev = 1;
            for (int n = 1; n <= k; n++)
            {
                prev = prev * x / n; 
                sum += prev;
            }

            Console.WriteLine("Out: {0}", sum);
            //x^n / n!
        }
    }
}
