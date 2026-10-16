using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal partial class Program
    {
        // Ввод целого числа с проверкой
        private int ReadInt(string message)
        {
            int n;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Ошибка, введите целое число: ");
            }

            return n;
        }

        // Ввод целого числа в диапазоне
        private int ReadIntInRange(string message, int min, int max)
        {
            int n = ReadInt(message);
            while (n < min || n > max)
            {
                n = ReadInt($"Число должно быть от {min} до {max}: ");
            }

            return n;
        }

        // Ввод одного символа
        private char ReadChar(string message)
        {
            char c;
            Console.Write(message);
            while (!char.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Ошибка, введите ровно один символ: ");
            }

            return c;
        }

        // Ввод массива
        private int[] ReadArray(string name)
        {
            int n = ReadIntInRange($"Введите количество элементов {name}: ", 0, 1000);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = ReadInt($"Введите элемент {name}[{i}]: ");
            }

            return arr;
        }

        // Проверка ввода меню
        private bool IsValidChoice(string choice)
        {
            string[] valid =
            {
                "0", "1.2", "1.4", "1.6", "1.8", "1.10",
                "2.2", "2.4", "2.6", "2.8", "2.10",
                "3.2", "3.4", "3.6", "3.8", "3.10",
                "4.2", "4.4", "4.6", "4.8", "4.10"
            };

            return Array.IndexOf(valid, choice) >= 0;
        }

        // Вывод меню
        private void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1.2  - SumLastNums");
            Console.WriteLine("1.4  - IsPositive");
            Console.WriteLine("1.6  - IsUpperCase");
            Console.WriteLine("1.8  - IsDivisor");
            Console.WriteLine("1.10 - LastNumSum (пять чисел)");
            Console.WriteLine("2.2  - SafeDiv");
            Console.WriteLine("2.4  - MakeDecision");
            Console.WriteLine("2.6  - Sum3");
            Console.WriteLine("2.8  - Age");
            Console.WriteLine("2.10 - PrintDays");
            Console.WriteLine("3.2  - ReverseListNums");
            Console.WriteLine("3.4  - Pow");
            Console.WriteLine("3.6  - EqualNum");
            Console.WriteLine("3.8  - LeftTriangle");
            Console.WriteLine("3.10 - GuessGame");
            Console.WriteLine("4.2  - FindLast");
            Console.WriteLine("4.4  - Add");
            Console.WriteLine("4.6  - Reverse");
            Console.WriteLine("4.8  - Concat");
            Console.WriteLine("4.10 - DeleteNegative");
            Console.WriteLine("0    - Выход");
            Console.Write("Ваш выбор: ");
        }
    }
}
