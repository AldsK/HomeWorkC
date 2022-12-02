// int size = 9;
// int[] number = new int[size];
// void FillArray(int[] number, int min, int max)
// {
//     Random rand = new Random();
//     int Length = number.Length;
//     for (int i = 0; i < Length; i++)
//     {
//         number[i] = rand.Next(min, ++max);
//     }
// }
// void PrintArray(int[] number)
// {
//     int Length = number.Length;
//     Console.Write("[");
//     for (int i = 0; i < Length; i++)
//     {
//         Console.Write(number[i] + " ");
//     }
//     Console.WriteLine("]");
// }
// void ReverseArray(int[] number)
// {
//     int Length = number.Length;
//     int maxIndex = Length -1;
//     int[] result = new int[Length];
//     for (int i = 0; i < Length; i++)
//     {
//         result[maxIndex - i] = number[i];
//     }
//     Console.WriteLine($"[{String.Join(",", result)}]");
// }

// FillArray(number, 1, 9);
// PrintArray(number);
// ReverseArray(number);
// PrintArray(number);

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник со сторонами такой длины.

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Random rand = new Random();
// int number = rand.Next(100, 1000);
// Console.WriteLine(number);
// int number = 14;
// void Zadacha42(int number)
// {
//     int sum = 0;
//     int result = 0;
//     while (number > 0)
//     {
//         sum = number % 2;
//         result = result * 10;
//         number /= 2;
//         Console.Write(result);
//     }
    
// }
// Zadacha42(number);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int num = 5;
void Zadacha44(int num)
{
    
    int firstNum = 0;
    int secondNum = 1;
    int result = 0;
    int count = 2;
    Console.Write(firstNum + " ", secondNum + " ");
    while (count < num)
    {
        result = firstNum + secondNum;
        Console.Write(result + " ");
        firstNum = secondNum;
        secondNum = result;
        count++;
    }
}
Zadacha44(num);