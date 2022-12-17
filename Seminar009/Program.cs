using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа
            // в промежутке от 1 до N
            // void Zadacha63()
            // {
            //     Console.WriteLine("Введите число: ");
            //     int number = Convert.ToInt32(Console.ReadLine());
            //     int counter = 1;
            //     Recursion(number, counter);
            // }
            // // Zadacha63();

            // void Zadacha65()
            // {
            //     int n = Convert.ToInt32(Console.ReadLine());
            //     // int m = Convert.ToInt32(Console.ReadLine());
            //     Recursion(n, m);
            // }
            // // Zadacha65();

            // void Zadacha66()
            // {
            //     int n = Convert.ToInt32(Console.ReadLine());
            //     Recursion(n);
            //     if (a == 0) return 0;
            //     return a % 10 + Recursion69(a / 10);
            // }
            // Zadacha66();
            // void Zadacha69()
            // {
            //     Console.WriteLine("Введите число: ");
            //     int a = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Введите число степени: ");
            //     int b = Convert.ToInt32(Console.ReadLine());
            //     Recursion69(a, b);
                
            // }
            // Zadacha69();
            // void Recursion69(int a, int b, int sum = 1)
            // {
            //     if (b == 0)
            //     {
            //         Console.WriteLine(sum);
            //         return;
            //     }
            //     sum = sum * a;
            //     b--;
            //     Recursion69(a, b, sum);

            // }

            // void Recursion63 (int n, int m = 1)
            // {
            //     if (n > m) return;
            //     Console.Write($"{n} \t");
            //     n++;
            //     Recursion(n, m);
            // }
            // void Recursion (int n, int sum = 0)
            // {
            //     if (n == 0)
            //     {
            //         Console.WriteLine(sum);
            //         return;
            //     }
            //     sum += n % 10;
            //     n /= 10;
            //     Recursion(n, sum);
            // }
            // Разбор ДЗ 

            // void Zadacha47()
            // {
            //     int rows = 4;
            //     int columns = 5;
            //     double[,] array = new double[rows,columns];
            //     FillArray(array);
            //     PrintArray(array);
            // }
            // Zadacha47();

            void Zadacha50()
            {
                int rows = 4;
                int columns = 5;
                int[,] array = new int[rows,columns];
                FillArray(array);
                PrintArray(array);
                int n = 5 - 1;
                int m = 3 - 1;
                if (n >= 0 && 
                    m >= 0 &&
                    n <= rows && 
                    m <=  columns);
                Console.WriteLine(array[n,m]);
            }
            Zadacha50();
            static void FillArrayDouble(double[,] array)
            {
                Random rand = new Random();
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                            {
                                array[i,j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
                            }
                    }
            }
            static void PrintArrayDoube(double[,] array, string text = "Вывод двумерного массива")
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                Console.WriteLine(text);
                for (int i = 0; i < rows; i++)
                    {
                    for (int j = 0; j < columns; j++)
                        {
                            Console.Write($"{array[i,j]}\t");
                        }
                Console.WriteLine();
                    }
            }
            static void FillArray(int[,] array)
            {
                Random rand = new Random();
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                            {
                                array[i,j] = rand.Next(1, 100);
                            }
                    }
            }
            static void PrintArray(int[,] array, string text = "Вывод двумерного массива")
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                Console.WriteLine(text);
                for (int i = 0; i < rows; i++)
                    {
                    for (int j = 0; j < columns; j++)
                        {
                            Console.Write($"{array[i,j]}\t");
                        }
                Console.WriteLine();
                    }
            }
        }
    }
}
