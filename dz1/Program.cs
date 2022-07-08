﻿//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень: ");
        int degree = Convert.ToInt32(Console.ReadLine());
        int numbers = DegreeNumbers(number, degree);
        Console.WriteLine("Результат " + numbers);
        }
        static int DegreeNumbers (int x, int y)
        {
            int result = 1;
            for(int i = 0; i < y; i++)
            {
                result = result * x;
            }
            return result;
        }
    }
}
