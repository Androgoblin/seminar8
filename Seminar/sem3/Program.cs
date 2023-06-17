// Напишите программу , которая принимает на вход координаты точек (x,y)
// (x )не равен 0 и(y) тоже :выдаёт номер четверти где находится

// int FindQuad(int x, int y)
// {
//   if (x >  0 && y < 0 )
//    {
//     return 1;
//    }
//   if (x <  0 && y > 0 )
//     {
//     return 2;
//     }
//   if (x <  0 && y < 0 )
//     {
//     return 3;
//     }
//   if (x >  0 && y < 0 )
//     {
//     return 4 ;
//     }
 
//  return 0;

// }

// System.Console.WriteLine("input x, coordinate: ");
// int x = System.Convert.ToInt32( Console.ReadLine());
// System.Console.WriteLine("input y, coordinate: ");
// int y = System.Convert.ToInt32( Console.ReadLine());

// System.Console.WriteLine($" Point with x, coordinate ({x}) and y  ({y}) belongs to {FindQuad(x,y)} quard ");

//задача 3
////Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance ( double xa,double ya ,double xb,double yb)
// {
//    return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2)),2);
// }

// System.Console.WriteLine("input x coordinate point A : ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input y coordinate point A : ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input x coordinate point B : ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input y coordinate point B : ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between point A and B -> { FindDistance (xa,ya,xb,yb)} ");

// Задача 2.Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y)

// void Diapozone(int x)
// {
   
   
//       if (x == 1) 
     
//       {
//        System.Console.WriteLine("x + and y +");
//       }
     
//       if (x == 2)
     
//       {
//       System.Console.WriteLine("x - and y +");
//       }  
     
//       if (x == 3)
     
//       {
//       System.Console.WriteLine("x - and y -");
//       }  
     
//       if (x == 4)
     
//       {
//       System.Console.WriteLine("x + and y -");
//       }
   
//      System.Console.WriteLine("Ввели не существующую четверть");
    

// }
//  System.Console.WriteLine("Введите четверть -> ");
//  int x = Convert.ToInt32(Console.ReadLine());
// Diapozone(x);

//  void Quad( int x )
// {  
//    int count = 1; 
//    while (count <= x)
//  {
//   System.Console.WriteLine($" {count} -> {Math.Pow(count, 2)}");  
//   count ++;
//  }

   
// }
// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// Quad(x);
