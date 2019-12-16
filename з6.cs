using System;

namespace лаб.раб__4_з6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1, A2, B1, B2, C1, C2, x, y;
            Console.WriteLine("введите A1: ");// Ввод A1
            A1= Convert.ToInt32(Console.ReadLine());// Вывод A1
            Console.WriteLine("введите A2: ");// Ввод A2
            A2 = Convert.ToInt32(Console.ReadLine());// Вывод A2
            Console.WriteLine("введите B1: ");// Ввод B1
            B1 = Convert.ToInt32(Console.ReadLine());// Вывод B1
            Console.WriteLine("введите B2: ");// Ввод B2
            B2 = Convert.ToInt32(Console.ReadLine());// Вывод B2
            Console.WriteLine("введите C1: ");// Ввод C1
            C1 = Convert.ToInt32(Console.ReadLine());// Вывод C1
            Console.WriteLine("введите C2: ");// Ввод C2
            C2 = Convert.ToInt32(Console.ReadLine());// Вывод C2
            x = ((C1*B2)+(C2*B1))/ ((A1 * B2) - (A2 * B1));
            y = ((C1 * A2) + (C2 * A1)) / ((B1 * A2) - (A1 * B2));
            Console.WriteLine("x= " + x);// Вывод x
            Console.WriteLine("y= " + y);// Вывод y
            Console.Read();
        }
    }
}
