using System;

class Program
{
    static void Main()
    {
        // Заданный массив целых чисел
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Нечетные числа из массива:");

        // Перебираем элементы массива и выводим только нечетные числа
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}