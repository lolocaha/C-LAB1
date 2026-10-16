using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal partial class Program
    {
        // Задание 1.2
        public int SumLastNums(int x)
        {
            return x % 10 + (x / 10) % 10;
        }

        // Задание 1.4
        public bool IsPositive(int x)
        {
            return x > 0;
        }

        // Задание 1.6
        public bool IsUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        // Задание 1.8
        public bool IsDivisor(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                return false;
            }
            if (a == 0 || b == 0)
            {
                return true;
            }

            return a % b == 0 || b % a == 0;
        }

        // Задание 1.10
        public int LastNumSum(int a, int b)
        {
            return a % 10 + b % 10;
        }

        // Задание 2.2
        public double SafeDiv(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }

            return (double)x / y;
        }

        // Задание 2.4
        public string MakeDecision(int x, int y)
        {
            if (x > y)
            {
                return $"{x} > {y}";
            }

            if (x < y)
            {
                return $"{x} < {y}";
            }

            return $"{x} == {y}";
        }

        // Задание 2.6
        public bool Sum3(int x, int y, int z)
        {
            return x + y == z || x + z == y || y + z == x;
        }

        // Задание 2.8
        public string Age(int x)
        {
            if (x % 10 == 1 && x % 100 != 11)
            {
                return $"{x} год";
            }

            if (x % 10 >= 2 && x % 10 <= 4 && (x % 100 < 11 || x % 100 > 14))
            {
                return $"{x} года";
            }

            return $"{x} лет";
        }

        // Задание 2.10
        public void PrintDays(string x)
        {
            switch (x)
            {
                case "понедельник":
                    Console.WriteLine("понедельник");
                    goto case "вторник";
                case "вторник":
                    Console.WriteLine("вторник");
                    goto case "среда";
                case "среда":
                    Console.WriteLine("среда");
                    goto case "четверг";
                case "четверг":
                    Console.WriteLine("четверг");
                    goto case "пятница";
                case "пятница":
                    Console.WriteLine("пятница");
                    goto case "суббота";
                case "суббота":
                    Console.WriteLine("суббота");
                    goto case "воскресенье";
                case "воскресенье":
                    Console.WriteLine("воскресенье");
                    break;
                default:
                    Console.WriteLine("это не день недели");
                    break;
            }
        }

        // Задание 3.2
        public string ReverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i + " ";
            }

            return result;
        }

        // Задание 3.4
        public int Pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;
        }

        // Задание 3.6
        public bool EqualNum(int x)
        {
            int digit = x % 10;
            while (x > 0)
            {
                if (x % 10 != digit)
                {
                    return false;
                }

                x /= 10;
            }

            return true;
        }

        // Задание 3.8
        public void LeftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        // Задание 3.10
        public void GuessGame()
        {
            Random random = new Random();
            int number = random.Next(0, 10);
            int guess = -1;
            int attempts = 0;

            while (guess != number)
            {
                Console.WriteLine("Введите число от 0 до 9:");
                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 9)
                {
                    Console.WriteLine("Неправильный ввод, введите число от 0 до 9:");
                }

                attempts++;
                if (guess != number)
                {
                    Console.WriteLine("Вы не угадали.");
                }
            }

            Console.WriteLine("Вы угадали!");
            Console.WriteLine($"Количество попыток: {attempts}");
        }

        // Задание 4.2
        public int FindLast(int[] arr, int x)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i;
                }
            }

            return index;
        }

        // Задание 4.4
        public int[] Add(int[] arr, int x, int pos)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pos)
                {
                    result.Add(x);
                }

                result.Add(arr[i]);
            }

            if (pos == arr.Length)
            {
                result.Add(x);
            }

            return result.ToArray();
        }

        // Задание 4.6
        public void Reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        // Задание 4.8
        public int[] Concat(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                result.Add(arr1[i]);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                result.Add(arr2[i]);
            }

            return result.ToArray();
        }

        // Задание 4.10
        public int[] DeleteNegative(int[] arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result.Add(arr[i]);
                }
            }

            return result.ToArray();
        }
    }
}
