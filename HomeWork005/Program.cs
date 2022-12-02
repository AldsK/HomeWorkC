
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Zadacha34()
{
int size = 9;
int[] numbers = new int[size];
FillArray(numbers, 100, 900);
PrintArray(numbers);
Console.WriteLine();
Nechetnie(numbers);
}
Zadacha34();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Zadacha36()
{
int size = 9;
int[] numbers = new int[size];
FillArray(numbers, 10, 90);
PrintArray(numbers);
Console.WriteLine();
SumChentih(numbers);
}
Zadacha36();

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 80,95

void Zadacha38()
{
int size = 9;
double[] numbers = new double[size];
FillArrayDouble(numbers, -100, 1000);
PrintArrayDouble(numbers);
Console.WriteLine();
DifferenceNumbers(numbers);
}
Zadacha38();

// Дополнительные задачи.

// Задача 1. Задан массив из случайных цифр на 15 элементов. 
// На вход подаётся трёхзначное натуральное число. Напишите программу, которая определяет, 
// есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.
void Zadacha1()
{
int size = 15;
int[] numbers = new int[size];
FillArray(numbers, 1, 10);
PrintArray(numbers);
Console.WriteLine();
SearchThreeNumbers(numbers);
}
Zadacha1();

// Задача 2. На вход подаются два числа случайной длины. 
// Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.
// 24, 132 -> {2, 6, 4, 4, 12, 8}
void Zadacha2()
{
Random rand = new Random();
int firstNumber = rand.Next(10, 100);
int secondNumber = rand.Next(100, 1000);
Console.WriteLine($"Вы получили рандомное число из двух элементов {firstNumber}");
Console.WriteLine($"Вы получили рандомное число из трех элементов {secondNumber}");
SearchRazryadArray(firstNumber, secondNumber);
}
Zadacha2();

void Zadacha3()
{

    int counter = 0;
    int sum = 0;
    while (counter < 100000)
    {
        sum += 1;

    }
}
void FillArray(int[] num, int minValue, int maxValue)
{
    Random rand = new Random();
    int Lenght = num.Length;
    for (int i = 0; i < Lenght; i++)
    {
        num[i] = rand.Next(minValue, maxValue);
    }
}
void PrintArray(int[] num)
{
    int Lenght = num.Length;
    Console.Write("Дан массив: ");
    Console.Write("[");
    for (int i = 0; i < Lenght; i++)
    {
        Console.Write(num[i] + ", ");
    }
    Console.WriteLine("]");
}
void Nechetnie(int[] num)
{
    int Lenght = num.Length;
    int counter = 0;
    for (int i = 0; i < Lenght; i++)
    {
        if (num[i] % 2 == 0)
        {
            counter += 1;
        }
    }
    Console.WriteLine($"Количество четным элементов массива = {counter}");
}
void SumChentih(int[] num)
{
    int Lenght = num.Length;
    int sum = 0;
    for (int i = 0; i < Lenght; i++)
    {
        if (i % 2 != 0)
        {
            sum += num[i];
        }
    }
    Console.WriteLine($"Сумма элементов массива стоящих на нечетных индексах = {sum}");
}
void DifferenceNumbers(double[] num)
{
    int Lenght = num.Length;
    double max = num[0];
    double min = num[0];
    double result = 0;
    for (int i = 0; i < Lenght; i++)
    {
        if (num[i] > max)
        {
            max = num[i];
        }
        if (num[i] < min)
        {
            min = num[i];
        }
    }
    result = max + min;
    Console.WriteLine($"Разница между максимальным {max} и {min} элементом массива = {result}");
}
void SearchThreeNumbers(int[] num)
{
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdNumber = number % 10;
number = number / 10;
int secondNumber = number % 10;
int firstNumber = number / 10;
    int Lenght = num.Length;
    bool flag = false;
    for (int i = 0; i < Lenght; i++)
    {
        if (num[i] == firstNumber && num[i + 1] == secondNumber && num[i + 2] == thirdNumber)
        {
            flag = true;
            Console.WriteLine($"Последовательноть {firstNumber},{secondNumber},{thirdNumber} есть в массиве");
        }
    }
    if (flag != true)
        Console.WriteLine("Такой последовательности - нет");
}
void SearchRazryadArray(int firstNumber, int secondNumber)
{
// Разбил первое число на разряды и записал их в массив
int[] arrayFirstNumber = new int[2];
for (int i = 0; i < arrayFirstNumber.Length; i++)
{   
    int sum = 0;
    sum = sum * 10 + firstNumber % 10;
    arrayFirstNumber[i] += sum;
    firstNumber /= 10;
}

int[] arraySecondNumber = new int[3];
// Разбила второе число на разряды и записал их в массив
for (int i = 0; i < arraySecondNumber.Length; i++)
{
    int sumTwo = 0;
    sumTwo = sumTwo * 10 + secondNumber % 10;
    arraySecondNumber[i] += sumTwo;
    secondNumber /= 10;
}
    int sumg = 0;
    Console.Write("Вы молучили массив: ");
    for (int i = 0; i < arrayFirstNumber.Length; i++)
    {
        for (int j = 0; j < arraySecondNumber.Length; j++)
        {
        int[] result = new int[6];
        result[i] = arrayFirstNumber[arrayFirstNumber.Length - 1 - i] * arraySecondNumber[arraySecondNumber.Length - 1 - j];
        Console.Write(result[i] + " ");
        }
    }
}
void FillArrayDouble(double[] num, int minValue, int maxValue)
{
    int Lenght = num.Length;
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        num[i] = Convert.ToDouble(rand.Next(minValue, maxValue)) / 10;
    }
    
}
void PrintArrayDouble(double[] num)
{
    int Lenght = num.Length;
    Console.Write("Дан массив: ");
    Console.Write("[");
    for (int i = 0; i < Lenght; i++)
    {
        Console.Write(num[i] + ", ");
    }
    Console.WriteLine("]");
}


