// 11. Напишите программу, которая выводит случайное трёхзначное число
//  и удаляет вторую цифру этого числа.
// int num = RandomNum(10, 100);
// Console.WriteLine(num);
// SearchNum(num);

// int RandomNum(int min, int max)
// {
//     int numbers = new Random().Next(min, ++max);
//     return numbers;
// }

// void SearchNum(int digit)
// {
//     int sum = 0;
//     sum = num / 10;
//     Console.WriteLine(sum);
// }


// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

// 16. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

void SearchNum()
{
    Console.WriteLine("Введите первое число: ");
    int OneDigit = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int TwoDigit = Convert.ToInt32(Console.ReadLine());
    if (OneDigit > TwoDigit)
    {
        TwoDigit = TwoDigit * TwoDigit;
        if (TwoDigit == OneDigit)
        {
            Console.WriteLine($"{TwoDigit} квадрат {OneDigit}");
        }
    }
    else if (OneDigit < TwoDigit)
    {
        OneDigit = OneDigit * OneDigit;
        if (OneDigit == TwoDigit)
        {
            Console.WriteLine($"{OneDigit} квадрат {TwoDigit}");
        }
    }
}
SearchNum();



