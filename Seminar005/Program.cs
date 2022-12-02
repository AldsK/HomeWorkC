// int[] array = new int[8];
// int[] GetArray(int[] arr)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 11);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine("]");
// }
// void ChangeArray(int[] arr)
// {
//     int temp;
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         for (int j = 0; j < array.Length - 1 - i; j++)
//         {
//             if (array[j] > array[j + 1])
//             {
//                 temp = array[j];
//                 array[j] = array[j + 1];
//                 array[j + 1] = temp;
//             }
//         }
//     }
// }
// GetArray(array);
// PrintArray(array);
// ChangeArray(array);
// PrintArray(array);

// int size = 8;
// int[] number = new int[size];
// void FillArray(int[] arr)
// {
//     for (int i = 0; i < number.Length; i++)
//     {
//         number[i] = new Random().Next(1, 10);
//     }
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < number.Length; i++)
//     {
//         Console.Write(number[i] + " ");
//     }
//     Console.WriteLine("]");
// }
// void ChangeArray(int[] arr)
// {
//     int temp;
//     for (int i = 0; i < number.Length - 1; i++)
//     {
//         for (int j = 0; j < number.Length - 1 - i; j++)
//         {
//             if (number[j] > number[j + 1])
//             {
//                 temp = number[j];
//                 number[j] = number[j + 1];
//                 number[j + 1] = temp;
//             }
//         }
//     }
// }
// void ReversArray(int[] arr)
// {
//     int temp;
//     for (int i = 0; i < number.Length - 1; i++)
//     {
//         temp = number[i];
//         number[i] = number[number.Length - 1 - i];
//         number[number.Length - 1 - i] = temp;
//     }
// }
// FillArray(number);
// PrintArray(number);
// Console.WriteLine();
// ChangeArray(number);
// PrintArray(number);
// ReversArray(number);
// PrintArray(number);

// A2.1. Дано двузначное число. Найти:
// а) число десятков в нем;
// б) число единиц в нем;
// в) сумму его цифр;
// г) произведение его цифр.

// A2.4. Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.
// A2.5. Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце. 
// Найти полученное число.

// Random Rand = new Random();
// int number = Rand.Next(100000, 999999);
// Console.WriteLine($"Вам выпало число {number}");
// void ChangerNumber(int num)
// {
//     int reversNum = 0;
//     int count = 0;
//     while (count < number)
//     {
//         reversNum = reversNum * 10 + number % 10;
//         number /= 10;
//         Console.WriteLine(reversNum);
//         count ++;
//     }
// }
// ChangerNumber(number);


// void ChangeNum(int num)
// {
//     int sum = 0;
//     sum = number % 100;
//     number /= 100;
//     sum = sum  * 10 + number;
//     Console.WriteLine(sum);
// }
// ChangeNum(number);

// A2.6. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале.
//  Найти полученное число.
// A2.7. Дано трехзначное число. Найти число, полученное при перестановке первой
//  и второй цифр заданного числа.
// void ZadachaA26(int num)
// {
//     int result = 0;
//     result = number % 10;
//     number /= 10;
//     result = result * 100 + number;
//     Console.WriteLine(result);
// }
// ZadachaA26(number);
// void ZadachaA27(int num)
// {
//     int count = 0;
//     int result = 0;
//     int numberOne = 0;
//     int numberTwo = 0;
//     int numberThree = 0;
//     numberOne = number % 10;
//     Console.WriteLine($" Первое число {numberOne}");
//     number /= 10;
//     Console.WriteLine(number);
//     numberTwo = number % 10;
//     Console.WriteLine($" Второе число {numberTwo}");
//     number /= 10;
//     Console.WriteLine(number);
//     numberThree = number % 10;
//     Console.WriteLine($" Третье  число {numberThree}");
//     result = (numberTwo * 100) + ((numberThree * 10) + numberOne);
//     Console.WriteLine(result);
// }
// ZadachaA27(number);

// A2.8. Дано трехзначное число. Найти число, полученное при перестановке второй 
// и третьей цифр заданного числа.
// A2.9. Дано трехзначное число, в котором все цифры различны. 
// Получить шесть чисел, образованных при перестановке цифр заданного числа.

// // A2.10. Дано четырехзначное число. Найти:
// а) сумму его цифр;
// б) произведение его цифр.

// void ZadachaA28()
// {
//     int result = 0;
//     int resultTwo = 1;
//     int count = 0;
//     while (count <= number)
//     {
//         result += number % 10;
//         resultTwo *= number % 10;
//         number /= 10;
//         count++;
//     }
//     Console.WriteLine($"Результат сложения {result} и произведения {resultTwo}");
// }
// ZadachaA28();
// A2.14. Дано натуральное число n (n > 999). Найти:
// а) число сотен в нем;
// б) число тысяч в нем.

// int number = 9000;
// void ZadachaA28()
// {
//     int result = 0;
//     int resultTwo = 0;
//     int counter = 0;
//     int countOne = 0;
//     int countTwo = 0;
//     while (counter < number)
//     {
//         result = number - 100;
//         countOne = counter + 1;
//         resultTwo = number - 1000;
//         countTwo++;
//         counter++;
//     } 
//     Console.WriteLine($"Сотен = {countOne}, Тысяч = {countTwo}");
// }
// ZadachaA28();

// int number = 1234567890;
// void Zadacha()
// {
//     int result = 0;
//     if (number < 100)
//     Console.WriteLine("Такой цифры нет");
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     result = number % 10;
//     Console.WriteLine(result);
// }
// Zadacha();

// int[] array = new int[]{12, 23, 37, 4, 52, 60, 7, 38, 91, 10, 11};
// int temp;
// int min;
// for (int i = 0; i < array.Length - 1; i++)
// {
//     min = i;
//     for (int j = 0; j < array.Length - 1; j++)
//     {
//         if (array[j] < array[min])
//         {
//             min = j;
//         }
//     }
//     temp = array[i];
//     array[i] = array[min];
//     array[min] = temp;

// }

// Console.WriteLine($"[{String.Join(",", array)}]");

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Задача 32: Напишите программу замены элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2

int size = 5;
int[] array = new int[size];
void FillArray(int[] num, int minValue, int maxVaule)
{
    Random rand = new Random();
    int Length = num.Length;
    for (int i = 0; i < Length; i++)
    {
        num[i] = rand.Next(minValue, ++maxVaule);
    }
    
}
void PrintArray(int[] num)
{
    int Length = num.Length;
    Console.Write("[");
    for (int i = 0; i < Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine("]");
}
// void SumPosAndNeg(int[] num)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     int Length = num.Length;
//     for (int i = 0; i < Length; i++)
//     {
//         if (num[i] < 0)
//         {
//             sumNeg += num[i];
//         }
//         if (num[i] > 0)
//         {
//             sumPos += num[i];
//         }
//     }
//     Console.WriteLine($"Сумма негативных чисел: {sumNeg}");
//     Console.WriteLine($"Сумма позитивных чисел: {sumPos}");
// }
// void ChangeNum(int[] num)
// {
//     int Length = num.Length;
//     for (int i = 0; i < Length; i++)
//     {
//         if (num[i] < 0)
//         {
//             num[i] = num[i] * - 1;
//         }
//         else if (num[i] > 0)
//         {
//             num[i] = num[i] * - 1;
//         }
//     }
// }
// void SearchNum(int[] num)
// {
//     int Length = num.Length;
//     int firstNum = 4;
//     int secondNum = 3;
//     bool flags  
//     for (int i = 0; i < Length; i++)
//     {
//         if (firstNum == num[i])
//         {
//             Console.WriteLine($"Число {firstNum} есть");
//         }
//         if (secondNum == num[i])
//         {
//             Console.WriteLine($"Число {secondNum} есть");
//         }
//     }
// }

void SearchNumbers(int[] num)
{
    int Length = num.Length;
    int counter = 0;
    for (int i = 0; i < Length; i++)
    {
        if (num[i] > 10 && num[i] < 99)
        {
            counter = counter + 1;
        }
    }
    Console.WriteLine($"Количество число от 10 до 99 = {counter}");
}
void Zadacha37(int[] num)
{
    int Length = num.Length;

    Console.Write("[");
    int[] arr = new int[Length / 2];
    for (int i = 0; i < Length / 2; i++)
    {
        arr[i] = array[i] * array[array.Length - 1 - i];
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("]");
}

//   /*     Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//     4; массив [6, 7, 19, 345, 3] -> нет
//     3; массив [6, 7, 19, 345, 3] -> да */
//     int size = 5;
//     int[] number = new int[size];
//     FillArray(number, 0, 5);
//     PrintArray(number);
//     int num = 4;
//     bool result = false;
//     for (int i = 0; i < number.Length; i++)
//     {
//         if (number[i] == num) result = true;
//     }

//     if (result) Console.WriteLine($"{num} - > ДА");
//     else Console.WriteLine($"{num} - > НЕТ");
// }
// Task_33();

// FillArray(array, 0, 9);
// PrintArray(array);
// SumPosAndNeg(array);
// FillArray(array, -9, 9);
// PrintArray(array);
// ChangeNum(array);
// Console.WriteLine();
// PrintArray(array);

// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Задача 35: Задайте одномерный массив из 10 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


FillArray(array, 1, 8);
PrintArray(array);
Zadacha37(array);









