// Задача 19
// Напишите программу которая принимает на вход пятизначное число и проверяет,
//  является ли оно полиндромом

Console.WriteLine("Напишите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
void Zadacha19(int num)
{
int firstNumber = number;
int secondNumber = 0;
int i = 0;
while (i < number)
{
    secondNumber = secondNumber * 10 + number % 10;
    number /= 10;
}
if (secondNumber == firstNumber)
    {
        Console.WriteLine("Полиндром");
    }
else
    Console.WriteLine("Это не полиндром");
}
Zadacha19(number);

// Задача 21: Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние межде ними в 3D пространстве
double x1 = 3;
double x2 = 6;
double y1 = 2;
double y2 = 1;
double z1 = 8;
double z2 = -7;
double line = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine(Math.Round(line,2));

// // Задача 23 Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
Console.WriteLine("Укажите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index <= number)
{
    Console.WriteLine($"Куб числа {index} = {index * index * index}");
    index++;
}
// Дополнительная задачи
// Задача 2. Дано трехзначное число N. Определить кратна ли трем сумма всех его цифр.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNum = number;
int sum = Zadacha2(number);
Kratnoe(sum);
int Zadacha2(int num)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
void Kratnoe(int num)
{
if (sum % 3 == 0)
{
    Console.WriteLine($"Сумма трех цифр {sum} числа {secondNum} - кратна 3");
}
else 
    Console.WriteLine("Не кратно");
}
// Задача 3.Дано трехзначное число N. Определить, есть ли среди его цифр 4 или 7.

Random Rand = new Random();
int number = Rand.Next(400, 408);
Console.Write("Дано трехначное рандомное число: ");
Console.WriteLine(number);
int digitXnumber = 0;
int firstNumber = 4;
int secondNumber = 7;
void Zadacha3(int digitOne, int digitTwo, int digitThree)
{
    while (number > 0)
    {
        digitXnumber = number % 10;
        if (digitXnumber == firstNumber)
        {
            Console.WriteLine($"Цифра {firstNumber} есть");
        }
        else if (digitXnumber == secondNumber)
        {
            Console.WriteLine($"Цифра {secondNumber} есть");
        }
        else

            Console.WriteLine("Таких цифр нет");
    }
}

Zadacha3(number, firstNumber, secondNumber);

// Задача 4. Дан массив длинной 10 элементов. Заполнить его последовательно  от 1 до 10.
int[] array = new int[10];
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] += i + 1;
    }
    Console.WriteLine($"[{String.Join(",", arr)}]");
}

FillArray(array);

// Задача 9
int firstPlayer;
int secondPlayer;
int resultFirstPlayer = 0;
int resultSecondPlayer = 0;
int i = 0;
while (i < 1000)
{
    Console.WriteLine("Первый игрок вводит число от 2 до 9: ");
    firstPlayer = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Второй игрок умножает на число первого от 2 до 9:");
    Console.WriteLine("Второй игрок вводит число от 2 до 9: ");
    secondPlayer = Convert.ToInt32(Console.ReadLine());
    resultSecondPlayer += firstPlayer * secondPlayer;
    Console.WriteLine($"Второй игрок имеет {resultSecondPlayer} очков");
    if (resultSecondPlayer > 1000)
    {
        Console.WriteLine("Выиграл второй игрок");
        break;
    }
    Console.WriteLine($"Первый игрок умножнает результат {resultSecondPlayer} на {firstPlayer}");
    resultFirstPlayer += resultSecondPlayer * firstPlayer;
    Console.WriteLine($"Первый игрок имеет {resultFirstPlayer} очков");
    if (resultFirstPlayer > 1000)
    {
        Console.WriteLine("Выиграл превый игрок");
        break;
    }
    Console.WriteLine($"Очков набрано {resultSecondPlayer + resultFirstPlayer}");
    i++;
}

// Задача не работает((
// Console.WriteLine("В этой таблице собрана среднемесячная температура с 2000 по 2010 год");
// int[] arr = new int[120];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(0, 30);
// }
// Console.WriteLine($"[{String.Join(",", arr)}]");
// Console.WriteLine("Укажите начало года: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите конец года: ");
// start = start - 1;
// int finish = Convert.ToInt32(Console.ReadLine());
// finish = finish - 1;
// finish = arr[arr.Length - 1];
// Console.WriteLine("Введите номер месяца: 1. Январь, 2. Феварль, 3. Март, 4. Апрель, 5 Май, 6. Июнь, 7. Июль, 8. Август, 9. Сентбярь, 10. Октябрь, 11. Ноябрь, 12. Декабрь");
// int mounth = Convert.ToInt32(Console.ReadLine());
// mounth = mounth - 1;
// int max = int.MinValue;
// int min = int.MaxValue;

// if (start == 2000)
// {
//     start = 1;
// }
// else if (start == 2001)
// {
//     start = 12;
// }
// else if (start == 2002)
// {
//     start = 24;
// }
// else if (start == 2003)
// {
//     start = 36;
// }
// else if (start == 2004)
// {   
//     start = 48;
// }
// else if (start == 2005)
// {
//     start = 60;
// }
// else if (start == 2006)
// {
//     start = 72;
// }
// else if (start == 2007)
// {
//     start = 84;
// }
// else if (start == 2008)
// {   
//     start = 96;
// }
// else if (start == 2009)
// {
//     start = 108;
// }
// else 
//     if (start == 2010)
// {   
//     Console.WriteLine("Выберете другой год, чтобы был промежуток =)");
// }
// if (finish == 2010)
// {
//     finish = arr[arr.Length - 1];
// }
// else if (finish == 2009)
// {
//     finish = arr[arr.Length - 1 - 12];
// }
// else if (finish == 2018)
// {
//     finish = arr[arr.Length - 1 - 24];
// }
// else if (finish == 2007)
// {
//     finish = arr[arr.Length - 1 - 36];
// }
// else if (finish == 2006)
// {
//     finish = arr[arr.Length - 1 - 48];
// }
// else if (finish == 2005)
// {
//     finish = arr[arr.Length - 1 - 60];
// }
// else if (finish == 2004)
// {
//     finish = arr[arr.Length - 1 - 72];
// }
// else if (finish == 2003)
// {
//     finish = arr[arr.Length - 1 - 84];
// }
// else if (finish == 2002)
// {
//     finish = arr[arr.Length - 1 - 96];
// }
// else if (finish == 2001)
// {
//     finish = arr[arr.Length - 1 - 108];
// }
// else 
//     if (finish == 2000)
// {
//     Console.WriteLine("В конечный интервал нелья указать начало года");
// }

// void temp(int[] arr, int start, int finish, int min, int max, int mounth)
// {
//     for (int i = start; i < finish; i++)
//     {
//         if (i % 12 == mounth)
//         {
//             if (arr[mounth] < min)
//             {
//                 min = arr[mounth];
//                 Console.WriteLine($"Максимальная температура в этом месяце {max}");
//             }
//             if (arr[mounth] > max)
//             {
//                 max = arr[mounth];
//                 Console.WriteLine($"Минимальная температуа в этом месяце {min}");
//             }
//         }
//     }
// }
// temp(arr, start, finish, min, max, mounth);








