// Урок 2. Базовые алгоритмы
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Программа принимает трехзначное чило");
// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// int SearchNum(int digit)
// {
//     num /= 10;
//     num %= 10;
//     return num;
// }
// Console.WriteLine(SearchNum(num));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 99)
// {
//     Console.WriteLine("Такой цифры нет");
// }
// else
//     {
//         while (num > 99)
//         {
//             num /= 10;
//             if (num < 999)
//             {
//                 num %= 10;
//                 Console.WriteLine($"Третья цифра {num}");
//             }
//         }
//     }

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// Console.WriteLine("Выберети цифры дня недели: 1 - Monday, 2 - Tuesday, 3 - Wednesday, 4 - Thursday, 5 - Friday, 6 - Saturday, 7 - Sunday: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 6 || number == 7)
// {
//     Console.WriteLine("Выходной");
// }
// else if (number >= 1 && number <= 5)
// {
//     Console.WriteLine("Будни");
// }
// else
//     Console.WriteLine("Нет такого числа");