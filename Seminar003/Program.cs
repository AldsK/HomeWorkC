// int k, d, n;
// Console.WriteLine("Введите порядковый номер дня недели: ");
// n = Convert.ToInt32(Console.ReadLine());
// n = n % 7 - 1;
// string[] DayWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Субботу", "Воскресенье"};
// for (int i = 0; i < DayWeek.Length; i++)
// {
//     if (n == i)
//     {
//         Console.WriteLine(DayWeek[i]);
//     }
// }

// С некоторого момента прошло 234 дня. 
// Сколько полных недель прошло за этот период

// A1.6. С начала суток прошло n секунд. Определить:
// а) сколько полных часов прошло с начала суток;
// б) сколько полных минут прошло с начала очередного часа;
// в) сколько полных секунд прошло с начала очередной минуты.


// Console.WriteLine("Сколько секунд: ");
// int s = Convert.ToInt32(Console.ReadLine());
// int SecInHours = 3600;
// int result = s / SecInHours;
// int resultTwo = s % SecInHours;
// int resultThree = resultTwo / 60;
// int resultFour = resultThree % 60;
// Console.WriteLine($"Часов {result}");
// Console.WriteLine($"Минут {resultThree}");
// Console.WriteLine($"секунды {resultFour}");

// Console.Write("Пересчет времени по секундам \nВведите количество секунд: ");
// int n = int.Parse(Console.ReadLine());
// if (n >= 86400)
//     {
//     n = n % 86400;
//     }
// int hours = n / 3600;
// int seconds_remains = n % 3600;
// int minutes = seconds_remains / 60;
// int seconds = seconds_remains % 60;
// Console.WriteLine("С момента начала суток прошло: \nЧасов - {0},\nМинут - {1}, \nСекунд - {2}",hours,minutes,seconds)


//17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void Zadacha17()
// {
//     Random rand = new Random();
//     // тип данных имя переменной = новый тип данных()
//     int x = rand.Next(-10, 11);
//     int y = rand.Next(-10, 11);
//     Console.WriteLine($"A({x}, {y})");
// }
// if (x > 0 && y > 0)
// {

// }
// else if (x < 0 && y > 0)
// {

// }

// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.WriteLine("Введите номер четверти: ");
// int nun = Convert.ToInt32(Console.ReadLine());
// Random rand = new Random();
// int x = rand.Next(-10, 10);
// int y = rand.Next(-10, 10);
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 1)
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine(x, y);
//     }
// }

// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// Console.WriteLine("Введите число N");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++)
// {
//     Console.WriteLine($"{i} * {i} = {i * i}");
// }
// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = 0;
// int numTwo = 0;
// while (index < num)
// {
//     numTwo = (numTwo * 10) + num % 10;
//     num /= 10;
// }
// if (numTwo == num)
//     Console.WriteLine("Полиндром");
// Console.WriteLine(num);
// Console.WriteLine(numTwo);

// Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sec = 0;
// while (num > 0)
// {
//     sec += num % 10;
//     num /= 10;
// }
// Console.WriteLine($"Сумма чисел {sec}");
// if (num % sec == 0)
// {
//     Console.WriteLine($"Число {num} кратно числу {sec}");
// }
// Console.WriteLine("Введти трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNum(int num)
// {
//     int sec = 0;
//     while (num > 0)
//  {
//      sec += num % 10;
//      num /= 10;
//  }
//  return sec;
// }
// int x = SumNum(number);
// Console.WriteLine(SumNum(number));
// void Kratnoe(int number, int SumNum)
// {
//     if (number % x == 0)
//     {
//         Console.WriteLine("Кратное");
//     }
// }
// Kratnoe(number, x);

// int num = 121211;
// int numtwo = num;
// int result = 0;
// int i = 0;
// while (i < num)
// {
//     result = (result * 10) + (num % 10);
//     num /= 10;
// }
// Console.WriteLine(numtwo);
// Console.WriteLine(result);
// if (numtwo == result)
//     Console.WriteLine("Полиндром");
// else
//     Console.WriteLine("НЕ полиндром");

// Random rand = new Random();
// int number = rand.Next(100, 999);
// int first = 4;
// int second = 7;
// int result = 0;
// Console.WriteLine(number);
// int i = 0;
// while(i < number)
// {
//     result = number % 10;
//     if (first == result)
//         Console.WriteLine($"Такая цифра есть {result}");
//     else if (second == result)
//         Console.WriteLine($"Такая цифра есть {result}");
//     else
//         Console.WriteLine("Такой цирфы нет");
//     number /= 10;
// }

// Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] += i + 1;
// }
// Console.WriteLine($"[{String.Join(",", array)}]");

// Задача 4. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. 
// На ввод подают номер месяца и год начали и конца.
// Определить самые высокие и низкие температуры для лета, осени, зимы 
// и весны в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.
// int[] arr = new int[60];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(-10, 40);
// }
// Console.WriteLine($"[{String.Join(",", arr)}]");
// Console.WriteLine("Укажите начало года: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите конец года: ");
// start = start - 1;
// int finish = Convert.ToInt32(Console.ReadLine());
// finish = finish - 1;
// finish = arr[arr.Length - 1];
// if (finish == 5)
// {
//     finish = arr[arr.Length - 1];
// }

// if (start == 1)
// {
//     start = 1;
// }
// else if (start == 2)
// {
//     start = 12;
// }
// else if (start == 3)
// {
//     start = 24;
// }
// else if (start == 4)
// {
//     start = 36;
// }
// else if (start == 5)
// {   
//     start = 48;
// }

// Console.WriteLine("Введите номер месяца: 1. Январь, 2. Феварль, 3. Март, 4. Апрель, 5 Май, 6. Июнь, 7. Июль, 8. Август, 9. Сентбярь, 10. Октябрь, 11. Ноябрь, 12. Декабрь");
// int mounth = Convert.ToInt32(Console.ReadLine());
// mounth = mounth - 1;
// int max = int.MinValue;
// int min = int.MaxValue;
// for (int i = start; i < finish; i++)
// {
//     if (i % 12 == mounth)
//     {
//         if (arr[i] < min)
//         {
//             min = arr[i];
//         }
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//     }
// }

// Console.WriteLine(min);
// Console.WriteLine(max);

// int firstPlayer;
// int secondPlayer;
// int resultFirstPlayer = 0;
// int resultSecondPlayer = 0;
// int i = 0;
// while (i < 1000)
// {
//     Console.WriteLine("Первый игрок вводит число от 2 до 9: ");
//     firstPlayer = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Второй игрок умножает на число первого от 2 до 9:");
//     Console.WriteLine("Второй игрок вводит число от 2 до 9: ");
//     secondPlayer = Convert.ToInt32(Console.ReadLine());
//     resultSecondPlayer += firstPlayer * secondPlayer;
//     Console.WriteLine($"Второй игрок имеет {resultSecondPlayer} очков");
//     if (resultSecondPlayer > 1000)
//     {
//         Console.WriteLine("Выиграл второй игрок");
//         break;
//     }
//     Console.WriteLine($"Первый игрок умножнает результат {resultSecondPlayer} на {firstPlayer}");
//     resultFirstPlayer += resultSecondPlayer * firstPlayer;
//     Console.WriteLine($"Первый игрок имеет {resultFirstPlayer} очков");
//     if (resultFirstPlayer > 1000)
//     {
//         Console.WriteLine("Выиграл превый игрок");
//         break;
//     }
//     Console.WriteLine($"Очков набрано {resultSecondPlayer + resultFirstPlayer}");
//     i++;
// }



// Задача 5. На вход подаётся число n > 4, указывающее длину пароля. Создайте метод, 
// генерирующий пароль заданной длины. 
// В пароле обязательно использовать цифру, букву и специальный знак.

// Задача 21: Напигите программу, 
// которая принимает на вход координаты двух точек и находит расстояние межде ними в 2D пространстве
// A (3,6); B(2,1)
// Возвести в квадрт Math.Pow
// Найти квадратный корень Math.Sqrt
// Math.sqrt(Math.Pow(x2 - x1), 2) + Math.Pow((y2 - y1), 2)
// double x1 = 3;
// double x2 = 6;
// double y1 = 2;
// double y2 = 1;
// double line = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
// Console.WriteLine(line);

// int num = 5;
// int i = 1;
// while (i < 5)
// {
//     Console.WriteLine($"Квадрат числа {i} = {Math.Pow((i),2)}");
//     i++;
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100)
// {
//     Console.WriteLine("Такого числа нет");
// }
// else
//     while (number > 1000)
//     {
//         number /= 10;
//     }
// Console.WriteLine($"Ваша цифра =  {number % 10}");