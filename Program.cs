// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

// void Polindrom (int num)
// { 
// if (num > 9999 && num < 100000 )
// {
//     if (num/10000 == num%10 && num%10000/1000 == num%100/10)
//        {
//        Console.WriteLine("Число является полиндромом");
//        }
//     else
//        {
//        Console.WriteLine("Число не является полиндромом");
//        }
// }
// else
// {
//    Console.WriteLine("Число не является пятизначным!"); 
// }
// }
// Console.WriteLine("Введите пятизначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Polindrom(num);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//  double N (double x1, double y1, double x2, double y2, double z1, double z2)
//  {
//    double A = x1 - x2;
//    double B = y1 - y2;
//    double C = z1 - z2;
//    double D = Math.Sqrt(A*A + B*B + C*C);

//    return D;
//  }

//  Console.WriteLine("Введите координаты x1");
//  double x1 = Convert.ToDouble(Console.ReadLine());
//   Console.WriteLine("Введите координаты y1");
//  double y1 = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Введите координаты z1");
//  double z1 = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Введите координаты x2");
//  double x2 = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Введите координаты y2");
//  double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты z2");
//  double z2 = Convert.ToDouble(Console.ReadLine());

// double result = N(x1, y1, x2, y2, z1, z2);
// Console.WriteLine(result);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// void Cub(int number)
// {
//     for (int i = 1; i < number + 1; i++)
//     {
//         Console.WriteLine(i * i * i);
//     }
// }

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// Cub(N);