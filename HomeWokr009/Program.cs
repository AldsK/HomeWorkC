using System;

namespace Project
{
    class Program
    {
        static void  Main(string[] args)
        {
            // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
            // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

            // M = 1; N = 9. -> "3, 6, 9"
            // M = 13; N = 20. -> "15, 18"

            // static void Zadacha64()
            // {
            //     Console.WriteLine("Введите первое значение: ");
            //     int m = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Введите второе значение: ");
            //     int n = Convert.ToInt32(Console.ReadLine());
            //     Recursion64(m, n);
            // }
            // Zadacha64();
            // // Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
            // который найдёт сумму натуральных элементов в промежутке от M до N.

            // M = 1; N = 15 -> 120
            // M = 4; N = 8. -> 30
            // static void Zadacha66()
            // {
            //     Console.WriteLine("Введите первое значение: ");
            //     int m = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Введите второе значение: ");
            //     int n = Convert.ToInt32(Console.ReadLine());
            //     Recursion66(m, n);
            // }
            // Zadacha66();
            // static void Recursion66(int m, int n, int sum = 0)
            // {
            //     if (m > n)
            //     {
            //         Console.WriteLine($"Сумма элементов = {sum}");
            //         return;
            //     }
            //     sum += m;
            //     m++;
            //     Recursion66(m, n, sum);
            // }
            static void ZadachaFact()
            {
                Console.WriteLine("Введите число: ");
                int m = Convert.ToInt32(Console.ReadLine());
                RecursionFact(m);
            }
            ZadachaFact();
            static void RecursionFact(int m, int sum = 1, int counter = 1)
            {
                if (counter > m)
                {
                    Console.WriteLine($"Факториал = {sum}");
                    return;
                }
                sum *= counter;
                counter++;
                RecursionFact(m, sum, counter);
            }



            // static void Recursion64(int m, int n)
            // {
            //     if (m > n) return;
            //     if (m % 3 == 0)
            //     {
            //         Console.Write($"{m}, ");
            //     }
            //     m++;
            //     Recursion64(m, n);
            // }
            

            

            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
            // Даны два неотрицательных числа m и n.
            // m = 2, n = 3 -> A(m,n) = 9
            // m = 3, n = 2 -> A(m,n) = 29

            static void Zadacha68()
            {
                // функция ack(n, m)
                // если n = 0
                // вернуть m + 1
                // иначе, если m = 0
                // вернуть ack (n - 1, 1)
                // еще
                // вернуть ack(n - 1, ack (n, m - 1))
                int n = 2;
                int m = 2;
                Recursion68(n, m);
            }
            Zadacha68();
            static void Recursion68(int n, int m)
            {
                if (m == 0)
                {
                    n + 1;
                }
                if (m > 0)
                {
                    n = 0;
                    Recursion68(m -1, 1);
                }
                if (m > 0 && n > 0)
                {
                    Recursion68(m - 1, Recursion68(m, n - 1));
                }
 
            }

        }
    }
}