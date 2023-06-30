// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray ( int size)
// {  
//     int [] array = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++) 
//     {
//         array[i] = rand.Next(100, 1000); 
//     }
//     return array;  
// } 
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// void EvenNumbers( int[] array)
//  {
//     int counte = 0;
//     for (int i = 0; i < array.Length; i++)
//    { 
//     if (array[i] % 2==0)
//       counte ++ ;
//    }
//      System.Console.WriteLine($"Количество чётных чисел в массиве -> {counte}");
//  }

// System.Console.WriteLine();
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size);

// PrintArray(myArray);
// EvenNumbers(myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.Write("Введите количество элементов массива: ");
// int array = Convert.ToInt32(Console.ReadLine());
// int[] RandomArray = new int[array];

// void masiv(int a)
// {
//  for (int i = 0; i < array; i++)
//  {
//  RandomArray[i] = new Random().Next(1,9);
//  Console.Write(RandomArray[i] + " ");
//  }

// }

// int SumElements(int[] RandomArray)
// {
// int result = 0;

// for (int i=0 ; i<RandomArray.Length;i++)
// if (i%2 == 1)
// {
// result+= RandomArray[i];
// }
// return result;
// }

// masiv(array);
// System.Console.WriteLine();
// Console.Write($"Cумма элементов, стоящих на нечётных позициях: {SumElements(RandomArray)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.Write("Введите количество элементов массива: ");
// int array = Convert.ToInt32(Console.ReadLine());
// double[] RandomArray = new double[array];

// void mas(int array)
// {
// Random rand = new Random();
// for (int i = 0; i < array; i++)
// {
// RandomArray[i] = rand.NextDouble();
// Console.Write($"{RandomArray[i]:f2};  ");
// }

// }

// double difference(double[] RandomArray)
// {
// double min = RandomArray[0];
// double max = RandomArray[0];
// int i = 1;
// while (i < RandomArray.Length)
// {
// if (max<RandomArray[i])
// max = RandomArray[i];
// if (min>RandomArray[i])
// min = RandomArray[i];
// i = i + 1;
// }
// return max-min;
// }

// mas(array);
// Console.Write($"Разница между максимальным и минимальным элементов массива: {difference(RandomArray):f2} ");

