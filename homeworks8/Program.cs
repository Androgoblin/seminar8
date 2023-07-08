// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] array  = new int [rows,columns];
// ArrayRandomNumbers(array);
// PrintArray(array);
// System.Console.WriteLine();
// Console.WriteLine($"sorted array: ");
// System.Console.WriteLine();
// OrderArrayLines(array);
// PrintArray(array);
// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }


// void ArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
        
//         Console.WriteLine();
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//  Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] array  = new int [rows,columns];
// ArrayRandomNumbers(array);
// PrintArray(array);
// System.Console.WriteLine();

// int minSumRows = 0;
// int sumRows = SumRowsElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumRows = SumRowsElements(array, i);
//   if (sumRows > tempSumRows)
//   {
//     sumRows = tempSumRows;
//     minSumRows = i;
//   }
// }

// Console.WriteLine($"{minSumRows+1} - row with the smallest sum = ({sumRows}) elements ");


// int SumRowsElements(int[,] array, int i)
// {
//   int sumRows = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumRows += array[i,j];
//   }
//   return sumRows;
// }

//  int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

 

//  void ArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
        
//         Console.WriteLine();
//     }
// }


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Enter number of rows first array: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns first array and rows second array : ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns second array: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// int [,] FirstArray  = new int [rows1,columns];
// ArrayRandomNumbers(FirstArray);
// System.Console.WriteLine($"First array: " );
// PrintArray(FirstArray);
// System.Console.WriteLine();

// int [,] SecondArray  = new int [columns,columns2];
// ArrayRandomNumbers(SecondArray);
// System.Console.WriteLine($"Second array: " );
// PrintArray(SecondArray);
// System.Console.WriteLine();

// int[,] resultArray = new int[rows1,columns2];

// MultiplyArray(FirstArray, SecondArray, resultArray);
//  Console.WriteLine($"product of two array:");
// PrintArray(resultArray);
 
//  void MultiplyArray(int[,] FirstArray, int[,] SecondArray, int[,] resultArray)
// {
//   for (int i = 0; i < resultArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultArray.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < FirstArray.GetLength(1); k++)
//       {
//         sum += FirstArray[i,k] * SecondArray[k,j];
//       }
//       resultArray[i,j] = sum;
//     }
//   }
// }
 
//  int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

 
//  void ArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
        
//         Console.WriteLine();
//     }
// }


// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

   
// Console.WriteLine($" Enter the size of the array  X : Y : Z");
// int x = InputNumbers("Enter X: ");
// int y = InputNumbers("Enter Y: ");
// int z = InputNumbers("Enter Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {

//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write($" {array3D[i,j,k]}({i},{j},");
//         Console.Write( $"{k}) ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }




// / Задача 62: Заполните спирально массив 4 на 4.
// // 1 2 3 4
// // 12 13 14 5
// // 11 16 15 6
// // 10 9 8 7

// Console.Write("Enter array size: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();
// int[,] Spiral = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= Spiral.GetLength(0) * Spiral.GetLength(1))
// {
//   Spiral[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < Spiral.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= Spiral.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > Spiral.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(Spiral);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }