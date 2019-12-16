using System;

namespace лаб.раб__4_з4
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1, V2, S, S1, T;
            Console.WriteLine("введите V1: ");// Ввод V1
            V1 = Convert.ToInt32(Console.ReadLine());// Вывод V1
            Console.WriteLine("введите V2: ");// Ввод V2
            V2 = Convert.ToInt32(Console.ReadLine());// Вывод V2
            Console.WriteLine("введите S: ");// Ввод S
            S = Convert.ToInt32(Console.ReadLine());// Вывод S
            Console.WriteLine("введите T: ");// Ввод T
            T = Convert.ToInt32(Console.ReadLine());// Вывод T
            S1 = S + ((V1 + V2) * T);
            Console.WriteLine("S1= " + S1);// Вывод S1
            Console.Read();
        }
    }
}
