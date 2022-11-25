// Задача 25: Используя определение степени числа, напишите цикл, 
// который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// Первый вариант
Console.WriteLine("Введите число А: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double numberB = Convert.ToInt32(Console.ReadLine());
double sum = Math.Pow(numberA, numberB);
Console.WriteLine(sum);
// Второй вариант
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int num = numberA;
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int count = 1;
int sum = numberA;
while (count < numberB)
{
    sum = sum * num;
    count++;
}
Console.WriteLine($"{numberA} в степени {numberB} = {sum}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Random rand = new Random();
int number = rand.Next(1, 1000);
Console.WriteLine($"Вам выпало число {number}");
void SumNumber(int num)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр =  {sum}");
}
SumNumber(number);


// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
//и выводит отсортированный по модулю массив.

// -2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
// 6, 1, -33 -> [1, 6, -33]
int[] array = new int[8];
int[] GetArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-30, 30);
    }
    return array;
}
void ChangeArray(int[] arr)
{
    int temp;
    int min;
    for (int i = 0; i < array.Length; i++)
    {
        min = i;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < array[min])
            {
                min = j;
            }
        temp = array[i];
        array[i] = array[min];
        array[min] = temp;
        }
       
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}

GetArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);
