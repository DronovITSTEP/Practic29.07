using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic29._07
{

    internal class Program
    {
        /*
         Напишите метод, который возвращает произведение
        чисел в указанном диапазоне. 
        Границы диапазона передаются в качестве параметров.
         */
        static int GetMultipleNumbers(int lowerBound, int upperBound)
        {
            int result = 1;
            for (int i = lowerBound; i <= upperBound; i++)
            {
                result *= i;
            }
            return result;
        }

        /*
         Напишите метод, который проверяет является ли
        число числом Фибоначчи. Число передаётся в качестве
        параметра. Если число простое нужно вернуть из метода
        true, иначе false.
        */
        static bool IsFibonacci(int number)
        {
            return IsPerfectSquare(5 * number * number + 4) ||
                IsPerfectSquare(5 * number * number - 4);
        }

        static bool IsPerfectSquare(int number)
        {
            int squareRoot = (int)Math.Sqrt(number);
            return squareRoot * squareRoot == number;
        }

        /*
         Напишите метод, сортирующий массив по убыванию
        или возрастанию в зависимости от выбора пользователя.
        Алгоритм сортировки реализуйте самостоятельно.
        Например, может быть реализована сортировка методом
        перестановок.
         */
        static void SortArray(int[] arr, bool asceding)
        {
            int size = arr.Length;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (asceding)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                    else
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }

                }
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            /*if (IsFibonacci(5))
            {
                Console.WriteLine("5 true");
            }
            if (IsFibonacci(9))
            {
                Console.WriteLine("9 true");
            }
            if (IsFibonacci(13))
            {
                Console.WriteLine("13 true");
            }*/

            /*int mult = GetMultipleNumbers(2, 5);
            Console.WriteLine(mult);*/

            /*int[] arr = { 5, 8, 4, 25, 4, 6, 41, 6, 3 };
            SortArray(arr, false);

            foreach (int i in arr)
                Console.WriteLine(i);*/

        }

        static int Foo(int a, int b)
        {
            int res = a + b;
            a += 5;
            return res;
        }
        /*[модификатор_доступа] возвращаемый_тип_данных имя_функции (параметры)
        {
            // тело функции
        }*/
    }
}

