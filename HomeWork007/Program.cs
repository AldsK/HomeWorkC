// Задача 47. Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void Zadacha47()
{
    int rows = 3;
    int columns = 4;
    double[,] array = new double[rows,columns];
    FillArrayDouble(array);
    PrintArrayDouble(array);
}
Zadacha47();

//Задача 50. Напишите программу, которая на вход принимает индексы элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void Zadacha48()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows,columns];
    FillArray(array);
    PrintArray(array);
    SearchNumber(array);
}
Zadacha48();

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows,columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    SearchArithmetic(array);
}
Zadacha52();


void FillArray(int[,] array, int minValue = 1, int maxValue = 10)
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
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
    Console.WriteLine();
    }
}
void SearchNumber(int[,] array)
{
    Console.WriteLine("Введите индекс строки: ");
    double digitOne = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите индекс колонки: ");
    double digitTwo = Convert.ToDouble(Console.ReadLine());
    bool flag = false;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == digitOne && j == digitTwo)
            {
                flag = true;
                Console.WriteLine($"Вам выпало число: {array[i,j]}");
            }
        }
    }
    if (flag != true)
    {
        Console.WriteLine("Такого индекса нет =(");
    }
}
void FillArrayDouble(double[,] array)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(rand.NextDouble() * 30 - 10, 1);
        }
    }
}
void PrintArrayDouble(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
    Console.WriteLine();
    }
}
void SearchArithmetic(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        double count = 0;
        for (int i = 0; i < rows; i++)
        {
            count = count + 1;
            sum += array[i, j];
        }
        sum /= count;
        Console.Write($"Среднее арифметическое первого столбца: {Math.Round(sum,1)}");
        Console.WriteLine();
    }
}
