using System;

namespace лаб.раб_з3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, x, A1, y, A2;
            Console.WriteLine("введите A: ");// Ввод A
            A = Convert.ToInt32(Console.ReadLine());// Вывод A
            Console.WriteLine("введите x: ");// Ввод x
            x = Convert.ToInt32(Console.ReadLine());// Вывод x
            Console.WriteLine("введите y: ");// Ввод y
            y = Convert.ToInt32(Console.ReadLine());// Вывод y
             A1 = (1 * A) / x;
             A2 = (A * y) / x;
            Console.WriteLine("A1= " + A1);// Вывод A1
            Console.WriteLine("A2= " + A2);// Вывод A2
            Console.Read();
        }
    }
}

