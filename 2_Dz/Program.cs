/* 
Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1==k2&&b1==b2) Console.WriteLine("прямые совпадают");

else if (k1==k2) Console.WriteLine("прямые параллельны");

else
    {
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.Write("(" + x + "; " + y + ")");
    }



