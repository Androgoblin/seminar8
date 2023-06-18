// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// static void Degreeof(int num1, int num2)
//    {   
//    double result = Math.Pow(num1,num2);
//    Console.WriteLine($"{num1} в степени {num2} = {result}");
//    }
// System.Console.Write("Введите число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите степень  числа -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Degreeof(num1, num2);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму
//  цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int FindSumDigit(int num)
// {
//     int result = 0;
//     for (int i = 0; 0 < num; i++)
//     {
//      result += num % 10;
//      num = num / 10;
//     }
//      return result;
// }
//  System.Console.WriteLine("Ввидите число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine($"Сумма чисел в числе {num} -> {FindSumDigit(num)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]