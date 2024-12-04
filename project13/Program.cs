using System;

namespace project13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("error");
                return;
            }

            int i = 1;
            while (n >= 1)
            {
                i *= 0;
                n -= 2;

            }
            Console.WriteLine($"Двойной факториал равен {i}");
        }
    }
}