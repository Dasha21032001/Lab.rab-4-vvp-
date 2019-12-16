using System;

namespace лаб.раб__4_з5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, x;
            Console.WriteLine("введите A: ");// Ввод A
            A = Convert.ToInt32(Console.ReadLine());// Вывод A
            Console.WriteLine("введите B: ");// Ввод B
            B = Convert.ToInt32(Console.ReadLine());// Вывод B
            if (A != 0)
            {
                x = (-B) / A;
                Console.WriteLine("x= " + x);// Вывод x
            }
            else { Console.WriteLine("Ошибка "); }
            Console.Read();
        }
    }
}
