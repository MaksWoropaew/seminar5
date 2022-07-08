//1. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

//2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// массив [6, 7, 19, 345, 3] -> нет

// массив [6, 7, 19, 345, 3] -> да

//Размер массива от 5 до 10

//Числа в массива от -20 до 20

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