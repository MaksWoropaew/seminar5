


namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Введите число N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());
        int sumNumber = SumNumber(numberN);
        Console.WriteLine("Сумма цифр в числе: " + sumNumber);
        }
        static int SumNumber(int numberN)
        {
    
        int count = Convert.ToString(numberN).Length;
        int advance = 0;
        int result = 0;
        for (int i = 0; i < count; i++)
        {
            advance = numberN - numberN % 10;
            result = result + (numberN - advance);
            numberN = numberN / 10;
        }
        return result;
        }
    }
}