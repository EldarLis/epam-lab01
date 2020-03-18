using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double e, x = -1;

            while (x == -1 || x == 1)
            {
                Console.WriteLine("Input correct x (!= -1 or 1): ");
                x = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Input eps - pricision: ");
            e = Convert.ToDouble(Console.ReadLine());

            double main = ((x-1)/(x+1)), prev = main, p = 1, sum = main;

            while (Math.Abs(prev) >= e)
            {
                prev = (p / (p + 2)) * prev * main * main;
                sum += prev;
                p += 2;
            }

            Console.WriteLine("Out sum: {0}", sum);
        }
    }
}
