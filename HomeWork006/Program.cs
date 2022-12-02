// Задача41: Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// Console.WriteLine("Введите количество цифр для ввода: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// int counter = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine($"Введите число № {i + 1}");
//     numbers[i] = Convert.ToDouble(Console.ReadLine());
//     if (numbers[i] > 0)
//     {
//         counter++;
//     }
// }
// Console.WriteLine($"Количество чисел больше 0 = {counter}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите точку b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($"Две прямые пересекутся в ({x};{y})");