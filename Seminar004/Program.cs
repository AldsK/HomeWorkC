// Задача 25: Используя определение степени числа, напишите цикл, 
//который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Напишите натурально число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Напишите натурально число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// int sum = numberA;
// while (index < numberB)
// {
//     sum = sum * numberA;
//     index++;
// }
// Console.WriteLine(sum);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Random rand = new Random();
// int number = rand.Next(10, 1000);
// Console.WriteLine(number);
// int sum = 0;
// while (number > 0)
// {
//     sum += number % 10;
//     number /= 10;
// }
// Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел
//  и выводит отсортированный по модулю массив.

// -2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
// 6, 1, -33 -> [1, 6, -33]
// int number = 8;
// int[] GetArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-30, 30);
//     }
//     return array;
// }
// int[] superArray = GetArray(number);
// Console.WriteLine($"[{String.Join(",", superArray)}]");
// void ChangeArray(int[] arr)
// {   
//     int min = 0;
//     int temp = 0;
//     for (int i = 0; i < superArray.Length; i++)
//     {
//         min = i;
//         for (int j = 0; j < superArray.Length; j++)
//         {
//             if (superArray[j] < superArray[min])
//             {
//                 min = j;
//             }
//             temp = superArray[i];
//             superArray[i] = superArray[min];
//             superArray[min] = temp;
//         }
//     }
//     Console.WriteLine($"[{String.Join(",", superArray)}]");
// }
// ChangeArray(superArray);

// double num = 2;
// int numTwo = 4;
// double result = 0;
// for (int i = 0; i <= numTwo; i++)
// {
//     result = Math.Pow(num, i);
// }
// Console.WriteLine(result);

// Задача 24.
// Random rand = new Random();
// int number = rand.Next(10);
// Console.WriteLine(number);
// int count = 0;
// int index = 0;
// int sum = 0;
// while (index < number)
// {
//     count += 1;
//     Console.WriteLine(count);
//     sum += count;

//     index++;
// }
// Console.WriteLine(sum);
// while (number > 0)
// {
    
    
//     Console.Write($"{number} + {sum} = ");
//     sum += number;
//     Console.WriteLine(sum);
//     number--;
// }
// Console.WriteLine(sum);
// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// void CountNum(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num /= 10;
//         count++;
//     }
//     Console.WriteLine(count);
// }
// CountNum(number);


// Задача 26
// int number = 5;
// Console.WriteLine(number);
// void Zadacha26(int num)
// {
//     int sum = 1;
//     while(number > 0)
//     {
//         Console.Write($"{number} * {sum} = ");
//         sum *= number;
//         Console.WriteLine(sum);
//         number--;
//     }
// }
// Zadacha26(number);

// void ProizNum(int num)
// {
//     int count = 1;
//     int sum = 1;
//     while (count <= num)
//     {
//         Console.Write($"{sum} * {count} = ");
//         sum *= count;
//         Console.WriteLine(sum);
//         count++;
//     }
// }
// ProizNum(number);

// int[] array = new int[10];

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
        
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }
// FillArray(array);
// PrintArray(array);

// int number = 5;
// void PlusNum(int num)
// {
//     int count = 1;
//     int sum = 1;
//     while (count <= number)
//     {
//         Console.Write($"{count} * {sum} = ");
//         sum = sum * count;
//         Console.Write(sum);
//         count++;
//     }
// }
// PlusNum(number);

int[] array = new int[]{1,5,2,22,55,43,234,54,25};
int temp;
int max;
for (int i = 0; i < array.Length - 1; i++)
{
    max = array[i];
    for (int j = 0; j < array.Length - 1 - i; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
    }
    temp = max;
    max = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
Console.WriteLine($"[{String.Join(",", array)}]");
