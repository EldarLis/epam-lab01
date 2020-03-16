using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Input x and y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            z = Multiplication(x, y);

            Console.WriteLine("Multi: {0}", z);
        }

        static int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}
