// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void Zadacha53()
{
    int rows = 4;
    int columns = 3;
    int[,] array = new int[rows,columns];
    FillArray(array);
    PrintArray(array);
    ChangeLastArray(array);
    Console.WriteLine();
    PrintArray(array);
}
// Zadacha53();

void Zadacha55()
{
    int rows = 5;
    int columns = 5;
    int[,] array = new int[rows,columns];
    FillArray(array);
    PrintArray(array);
    ChangeArray(array);
    Console.WriteLine();
    PrintArray(array);
}
// Zadacha55();

void Zadacha57()
{
    int rows = 5;
    int columns = 5;
    int[,] array = new int[rows,columns];
    FillArray(array);
    PrintArray(array);
    int[] dictionary = new int[10];
    PrintSingleArray(dictionary, "Вывод одномерного массива");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dictionary[array[i,j]]++;
        }
    }
    // PrintSingleArray(directory, "Вывод одномерного массива");
}
Zadacha57();
void FillArray(int[,] array, int minValue = 1, int maxValue = 9)
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
void PrintSingleArray(int[] array, string text)
{
    // Random rand = new Random();
    int rows = array.Length;
    Console.WriteLine(text);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}
void ChangeLastArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows / 2; i++)
    {
        int temp = 0;
        for (int j = 0; j < columns; j++)
        {
            temp = array[i, j];
            array[i, j] = array[rows - 1 - i, j];
            array[rows - 1 - i, j] = temp;

        }
    }
}
void ChangeArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int min = rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[j,i] = array[i, j];
        }
    }
}

int[] arr = new int[]{98,100,52,32,54,6,5,36,8};
int temp = 0;
for (int i = 0; i < arr.Length - 1; i++)
{
    int indexMin = i;
    for (int j = 0; j < arr.Length - 1 - i; j++)
    {
        if (arr[indexMin] < arr[j])
        {
            indexMin = j;
        }
    temp = arr[indexMin];
    arr[indexMin] = arr[arr.Length - 1];
    arr[arr.Length - 1] = temp;
    }
}
Console.WriteLine($"[{String.Join(",", arr)}]");