using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {   
            // //
            // static void SortirovkaArray()
            // {
            //     int[] array = new int[9];
            //     FillArray(array);
            //     PrintArray(array);
            //     // BubbleSort(array);
            //     // Console.WriteLine();
            //     // PrintArray(array);
            //     VyborSort(array);
            //     Console.WriteLine();
            //     PrintArray(array);
            // }
            // SortirovkaArray();

            // static void FillArray(int[] array, int minValue = 1, int maxValue = 10)
            // {
            //     int Length = array.Length;
            //     Random rand = new Random();
            //     for (int i = 0; i < Length; i++)
            //     {
            //         array[i] = rand.Next(minValue, maxValue);
            //     }
            // }
            // static void PrintArray(int[] array, string text = "Вывод массива:")
            // {
            //     int Length = array.Length;
            //     Console.WriteLine(text);
            //     for (int i = 0; i < Length; i++)
            //     {
            //         Console.Write(array[i] + " ");
            //     }
            // }
            // static void BubbleSort(int[] array)
            // {
            //     int Length = array.Length;
            //     int temp = 0;
            //     for (int i = 0; i < Length; i++)
            //     {
            //         for (int j = 0; j < Length - i - 1; j++)
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
            // static void VyborSort(int[] array)
            // {
            //     int Length = array.Length;
            //     for (int i = 0; i < Length; i++)
            //     {
            //         int indexMax = i;
            //         for (int j = i + 1; j < Length; j++)
            //         {
            //            if (array[indexMax] < array[j])
            //            {
            //                 indexMax = j;
            //            }
            //         }
            //     int temp = array[i];
            //     array[i] = array[indexMax];
            //     array[indexMax] = temp;
            //     }
            // }
            // */

            int b = 2;
            int c = 7;
            int couneter = 1;
            int sum = 1;
            while (couneter < 20)
            {
                if (sum % b == 0)
                {
                    if (sum % c == 0)
                    {
                        Console.WriteLine(sum);
                    }
                }
            sum += 1;
            couneter++;
            }

            

        }
    }
}
