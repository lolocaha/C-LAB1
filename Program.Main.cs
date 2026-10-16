using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        private static void Main()
        {
            Program p = new Program();
            string choice = "";

            while (choice != "0")
            {
                p.PrintMenu();
                choice = Console.ReadLine() ?? "";

                while (!p.IsValidChoice(choice))
                {
                    Console.Write("Неверный пункт меню, повторите ввод: ");
                    choice = Console.ReadLine() ?? "";
                }

                Console.WriteLine();

                switch (choice)
                {
                    case "1.2":
                        {
                            int x = p.ReadInt("Введите число (не меньше двух цифр): ");
                            while (x > -10 && x < 10)
                            {
                                x = p.ReadInt("В числе должно быть не меньше двух цифр: ");
                            }

                            Console.WriteLine($"Результат: {p.SumLastNums(x)}");
                            break;
                        }
                    case "1.4":
                        {
                            int x = p.ReadInt("Введите число x: ");
                            Console.WriteLine($"Результат: {p.IsPositive(x)}");
                            break;
                        }
                    case "1.6":
                        {
                            char x = p.ReadChar("Введите символ x: ");
                            Console.WriteLine($"Результат: {p.IsUpperCase(x)}");
                            break;
                        }
                    case "1.8":
                        {
                            int a = p.ReadInt("Введите число a: ");
                            int b = p.ReadInt("Введите число b: ");
                            Console.WriteLine($"Результат: {p.IsDivisor(a, b)}");
                            break;
                        }
                    case "1.10":
                        {
                            int result = p.ReadInt("Введите 1-е число: ");
                            for (int i = 2; i <= 5; i++)
                            {
                                int next = p.ReadInt($"Введите {i}-е число: ");
                                Console.Write($"{result}+{next} это ");
                                result = p.LastNumSum(result, next);
                                Console.WriteLine(result);
                            }

                            Console.WriteLine($"Итого {result}");
                            break;
                        }
                    case "2.2":
                        {
                            int x = p.ReadInt("Введите число x: ");
                            int y = p.ReadInt("Введите число y: ");
                            Console.WriteLine($"Результат: {p.SafeDiv(x, y)}");
                            break;
                        }
                    case "2.4":
                        {
                            int x = p.ReadInt("Введите число x: ");
                            int y = p.ReadInt("Введите число y: ");
                            Console.WriteLine($"Результат: {p.MakeDecision(x, y)}");
                            break;
                        }
                    case "2.6":
                        {
                            int x = p.ReadInt("Введите число x: ");
                            int y = p.ReadInt("Введите число y: ");
                            int z = p.ReadInt("Введите число z: ");
                            Console.WriteLine($"Результат: {p.Sum3(x, y, z)}");
                            break;
                        }
                    case "2.8":
                        {
                            int x = p.ReadIntInRange("Введите возраст x: ", 0, int.MaxValue);
                            Console.WriteLine($"Результат: {p.Age(x)}");
                            break;
                        }
                    case "2.10":
                        {
                            Console.Write("Введите день недели (строчными буквами): ");
                            string x = Console.ReadLine() ?? "";
                            p.PrintDays(x);
                            break;
                        }
                    case "3.2":
                        {
                            int x = p.ReadIntInRange("Введите число x (не меньше 0): ", 0, int.MaxValue);
                            Console.WriteLine($"Результат: {p.ReverseListNums(x)}");
                            break;
                        }
                    case "3.4":
                        {
                            int x = p.ReadInt("Введите число x: ");
                            int y = p.ReadIntInRange("Введите степень y (не меньше 0): ", 0, int.MaxValue);
                            Console.WriteLine($"Результат: {p.Pow(x, y)}");
                            break;
                        }
                    case "3.6":
                        {
                            int x = p.ReadIntInRange("Введите число x (не меньше 0): ", 0, int.MaxValue);
                            Console.WriteLine($"Результат: {p.EqualNum(x)}");
                            break;
                        }
                    case "3.8":
                        {
                            int x = p.ReadIntInRange("Введите высоту x (��е меньше 1): ", 1, 100);
                            p.LeftTriangle(x);
                            break;
                        }
                    case "3.10":
                        {
                            p.GuessGame();
                            break;
                        }
                    case "4.2":
                        {
                            int[] arr = p.ReadArray("arr");
                            int x = p.ReadInt("Введите искомое число x: ");
                            Console.WriteLine($"Результат: {p.FindLast(arr, x)}");
                            break;
                        }
                    case "4.4":
                        {
                            int[] arr = p.ReadArray("arr");
                            int x = p.ReadInt("Введите число x: ");
                            int pos = p.ReadIntInRange($"Введите позицию pos (от 0 до {arr.Length}): ", 0, arr.Length);
                            int[] result = p.Add(arr, x, pos);
                            Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
                            break;
                        }
                    case "4.6":
                        {
                            int[] arr = p.ReadArray("arr");
                            p.Reverse(arr);
                            Console.WriteLine($"Результат: [{string.Join(", ", arr)}]");
                            break;
                        }
                    case "4.8":
                        {
                            int[] arr1 = p.ReadArray("arr1");
                            int[] arr2 = p.ReadArray("arr2");
                            int[] result = p.Concat(arr1, arr2);
                            Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
                            break;
                        }
                    case "4.10":
                        {
                            int[] arr = p.ReadArray("arr");
                            int[] result = p.DeleteNegative(arr);
                            Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
                            break;
                        }
                    case "0":
                        {
                            Console.WriteLine("Выход из программы.");
                            break;
                        }
                }
            }
        }
    }
}
