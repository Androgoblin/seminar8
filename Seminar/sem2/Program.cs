// int FindSum (int num1, int num2)
// {
//     int sum =num1 + num2;
//     return sum;
// }

// int x = 5;
// int y = 6;

// // int result = findSum(x,y);
// // System.Console.WriteLine(result);
//  можно так 
// System.Console.WriteLine(findSum(x,y));


// 1 задача
// Программа на ввод 2а числа и выводить ,является ли кратным первого числа второе
// 34,5 -> 
// 16, 4 -> кратно


// void checkEven(int num1, int num2)
// {
//     if (num1 % num2 == 0)
//         {
//             System.Console.WriteLine($"{num2} is even {num1}");
//         }
//        else
//         {
//             System.Console.WriteLine($"{num2} is  not even {num1} ,остаток -> {num1%num2}");
//         }
// }
// System.Console.WriteLine("Введите число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// checkEven (num1, num2);


// задача 2

// Напишите программу которая принимает на вход число и проверяет,кратно оно 7 и 23

// 14 -> нет
// 46 -> нет
// 161 -> да 

// bool checkEven(int num)
// {
//    if (num % 7 == 0 && num % 23 == 0) return true;
//    else return false;   
// }

// System.Console.Write(" Введите число -> ");

// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(checkEven(num));

//Задача 3
//напиши программу , которое вводит 3 х значное чило и удаляет вторую цифру этого числа


// int FindNum(int index) 
// {
//     System.Console.WriteLine(index);
//     int num1 = index / 100;
//     int num2 = index % 10;
//     int result = num1 * 10 + num2;
//     return result;
// }

// int index = new Random().Next(100, 1000);
// System.Console.WriteLine (FindNum(index));

//  задача 4
// напиши программу , принимает на вход 2 числа и проверяет явдяется квадратом другого

// void EventNum(int num1, int num2)
// {

//     if (num1 == num2 * num2)
//     {
//         System.Console.WriteLine($"  {num1} являетсятся квадратом {num2}");
//     }
//     else if (num2 == num1 * num1)
//     {
//         System.Console.WriteLine($"  {num2} являетсятся квадратом {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($" НЕ одно из чисел не является квадратом друг друга ");
//     }
// }

// System.Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// EventNum(num1, num2);
