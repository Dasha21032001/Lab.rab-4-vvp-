using System;

namespace Лаб.раб__4_з1
{
    class Program
    {
        static void Main(string[] args)
        {
           int a;
            double pi = 180;
            double l;
            Console.WriteLine("введите a: ");// Ввод a
            a= Convert.ToInt32(Console.ReadLine());// Вывод a
            if ((a > 0) && (a < 360))
            {
                l = a * (pi / 180);
                Console.WriteLine("l= " + l);// Вывод l
            }
            else { Console.WriteLine("Ошибка"); }
            Console.Read();
        }
    }
}
