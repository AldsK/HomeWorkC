using System;

namespace Project
{
    class Program
    {


        static void Main(string[] args)
        {
            // Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
            // элементы каждой строки двумерного массива.
            static void Zadacha54()
            {
                int rows = 4;
                int columns = 4;
                int[,] array = new int[rows,columns];
                FillArray(array);
                PrintArray(array);
                Console.WriteLine();
                // ChangeMinRows(array);
                VyborSort(array);
                PrintArray(array);
               

            }
            // Zadacha54();
            // Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, 
            // которая будет находить строку с наименьшей суммой элементов.
            static void Zadacha56()
            {
                int rows = 4;
                int columns = 5;
                int[,] array = new int[rows,columns];
                FillArray(array);
                PrintArray(array);
                SearchMinRows(array);
            }
            // Zadacha56();
            // Задача 58. Спираль
            static void Zadacha58()
            {
                int rows = 4;
                int columns = 4;
                int[,] array = new int[rows,columns];
                int indexRow = 0;
                int indexColumns = 0;

                int biasRow = 0;
                int biasColumns = 1;

                int steps = columns;


                for (int i = 0; i < array.Length; i++)
                {
                    array[indexRow, indexColumns] = i+1;
                    Console.Write($"[{indexRow},{indexColumns}] {array[indexRow, indexColumns]}");
                    steps--;
                    if (steps == 0)
                    {
                        int temp = biasRow;
                        biasRow = biasColumns;
                        biasColumns = temp;
                    }
                    indexRow += biasRow;
                    indexColumns += biasColumns;
                }
            }
            Zadacha58();

            static void FillArray(int[,] array, int minValue = -10, int maxValue = 10)
            {
                Random rand = new Random();
                maxValue++;
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                            {
                                array[i,j] = rand.Next(minValue, maxValue);
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
            static void ChangeMinRows(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                int temp = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int k = 0; k < columns - 1; k++)
                        {
                            if (array[j, k] < array[j, k + 1])
                            {
                                temp = array[j, k];
                                array[j, k] = array[j, k + 1];
                                array[j, k + 1] = temp;
                            }
                        }
                    }
                }
            }
            static void SearchMinRows(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                int min = int.MaxValue;
                int indexMin = 0;
                for (int i = 0; i < rows; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < columns; j++)
                    {
                        sum += array[i,j];
                        if (j == columns - 1)
                        {
                            Console.WriteLine($"Сумма первой строчки: {sum} \t");
                        }
                    }
                    if (sum < min)
                    {
                        min = sum;
                        indexMin = i;
                    }
                }
                Console.WriteLine($"Минимальная сумма {min}  находится в строке номер {indexMin+1}");
                
            }
            static void VyborSort(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        int indexMax = j;
                        for (int k = j + 1; k < columns; k++)
                        {
                            if (array[i, indexMax] > array[i, k])
                            {
                                indexMax = k;
                            }
                        }
                    int temp = array[i, j];
                    array[i, j] = array[i, indexMax];
                    array[i, indexMax] = temp;
                    }
                }
            }
        }



    }
}

