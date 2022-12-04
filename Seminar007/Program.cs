// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
void Zadacha46()
{
    int rows = 3;
    int columns = 4;
    int[,] number = new int[rows,columns];
    FillArray(number);
    PrintArray(number);
}
// Zadacha46();
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = i+j. 
//Выведите полученный массив на экран.
void Zadacha48()
{
    int rows = 3;
    int columns = 4;
    int[,] number = new int[rows,columns];
    FillArray48(number);
    PrintArray(number);
}

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
void Zadacha49()
{
    int rows = 3;
    int columns = 4;
    int[,] number = new int[rows,columns];
    FillArray(number);
    PrintArray(number);
    ChangeNumber(number);
    PrintArray(number);
}
// Zadacha49();
void Zadacha51()
{
    int rows = 3;
    int columns = 4;
    int[,] number = new int[rows,columns];
    FillArray(number);
    PrintArray(number);
    SearchSum(number);
    SearchSumTwo(number);
}
Zadacha51();

void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        // i = 0;
        for (int j = 0; j < columns; j++)
        {
            numbers[i,j] = rand.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            // В первой строке перебираются столбцы.
            Console.Write($"[{i},{j}]\t");
            Console.Write($"{numbers[i,j]}\t");
        }
    Console.WriteLine();
    }
}
void PrintArrayRows(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            // В первой строке перебираются столбцы.
            Console.Write($"[{i},{j}]\t");
            Console.Write($"{numbers[i,j]}\t");
        }
    Console.WriteLine();
    }
}
void FillArray48(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        // i = 0;
        for (int j = 0; j < columns; j++)
        {
            // numbers[i,j] = rand.Next(minValue, maxValue);
            numbers[i,j] = i + j;
        }
    }
}
void ChangeNumber(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                numbers[i,j] = numbers[i,j] * numbers[i,j];
            }
        }
    }
}
void SearchSum(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sum += numbers[i,j];
            }
        }
    }
    Console.WriteLine($"Сумма элементов {sum}");
}
void SearchSumTwo(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += numbers[i,i];
    }
    Console.WriteLine($"Сумма элементов {sum}");
}