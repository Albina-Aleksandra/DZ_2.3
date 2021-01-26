using System;

namespace DZ_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
                int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число нечетное.");
            }
        }
    }
}
