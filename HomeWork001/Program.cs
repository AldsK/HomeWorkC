// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.WriteLine("Введите первое число: ");
// int numOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numTwo = Convert.ToInt32(Console.ReadLine());
// if (numOne > numTwo)
// {
//     Console.WriteLine($"Число {numOne} больше числа {numTwo}");
// }
// else if (numOne < numTwo)
// {
//     Console.WriteLine($"Число {numTwo} больше числа {numOne}");
// }
// else 
//     Console.WriteLine($"Число равны");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
//из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число: ");
// int numOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numTwo = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int numThree = Convert.ToInt32(Console.ReadLine());
// if (numOne > numTwo)
// {
//     if (numOne > numThree)
//     {
//         Console.WriteLine($"Максимальное число {numOne}");
//     }
//     else
//         Console.WriteLine($"Максимальное число {numThree}");
// }
// else
//     if (numTwo > numThree)
//     {
//         Console.WriteLine($"Максимальное исло {numTwo}");
//     }
//     else
//         Console.WriteLine($"Максимальное число {numThree}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine("Четное число");
// }
// else
//     Console.WriteLine("Нечетное");

// Задача 8: Напишите программу, которая на вход принимает число (N > 0), 
//а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i < num)
// {
//     if (i % 2 == 0)
//     Console.Write(i + " ");
//     i++;
// }
